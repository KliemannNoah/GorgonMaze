using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JennyMove : MonoBehaviour
    {


        //controller for all Jenny movements
        public Animator jennyAni;

        //For the interface
        public GameObject leader;
        public GameObject follower;
        public Camera mainCamera;
        public float bubbleSize = 0.5f;
        public float stuckBubble = 0.5f;
        public int stuckTolerance = 200;
        public float speedRatio = 0.1f;
        public bool move = false;
        public bool scene = false; //changes to scene mode



        //For calculations
        private float xDis;
        private float zDis;
        private float speed;
        private int stuckUpdates = 0;
        private Vector3 lastPos;


        //Stored Animations as of 11/27/18

        //CAN BE ACCESSED FROM ANY OTHER ANIMATION STATE
        //jennyHide
        //jennyDeath
        //jennyAgony
        //jennyHurt
        //jennyArmAttack
        //jennyBiteAttack
        //jennyFeast



        // Use this for initialization
        void Start()
        {
            jennyAgony();
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown("space"))
            {
                jennyWalk();
                move = !move;
            }


            xDis = Mathf.Abs(leader.transform.position.x - follower.transform.position.x);
            zDis = Mathf.Abs(leader.transform.position.z - follower.transform.position.z);


            if (!scene)
            {
                if (xDis > bubbleSize || zDis > bubbleSize)
                {
                    move = true;
                    speed = Mathf.Max(xDis, zDis) * speedRatio;
                }
                else
                {
                    move = false;
                }
            }
            else
            {
                if (xDis > bubbleSize)
                {
                    move = true;
                    speed = xDis * speedRatio;
                }
                else
                {
                    move = false;
                }
            }

            Vector3 worldPoint = mainCamera.WorldToScreenPoint(follower.transform.localPosition);
            Vector3 leadWorldPoint = mainCamera.WorldToScreenPoint(leader.transform.localPosition);

            //teleportation
            if (worldPoint.x < 0 || worldPoint.z < 0 || worldPoint.x > Screen.width || worldPoint.z > Screen.height)
            {
                if (leadWorldPoint.x > 0 || leadWorldPoint.z > 0 || leadWorldPoint.x < Screen.width || leadWorldPoint.z < Screen.height)
                    follower.transform.position = new Vector3(leader.transform.position.x, leader.transform.position.y, leader.transform.position.z);
            }

            //Check if follower is stuck on an object. Note the change in position, and if it is too small too many times, then teleport

            if ((Mathf.Abs(lastPos.x - follower.transform.position.x) < stuckBubble) && (Mathf.Abs(lastPos.z - follower.transform.position.z)) < stuckBubble && move)
            {
                stuckUpdates++;
            }
            else
            {
                stuckUpdates = 0;
            }

            //If we decide the follower is stuck -> teleport
            if (stuckUpdates > stuckTolerance)
            {
                stuckUpdates = 0;
                follower.transform.position = new Vector3(leader.transform.position.x, leader.transform.position.y, leader.transform.position.z);
            }

            if (move)
            {
                float step = speed * UnityEngine.Time.deltaTime;
                follower.transform.position = Vector3.MoveTowards(follower.transform.position, leader.transform.position, step);
            }
            else
            {
                stuckUpdates = 0;
            }
            lastPos = follower.transform.position;



            if (Input.GetMouseButtonDown(0) || OVRInput.Get(OVRInput.RawButton.X))
            {
                jennyArmAttack();
            }

            if (Input.GetMouseButtonDown(1) || OVRInput.Get(OVRInput.RawButton.Y))
            {
                jennyWalk();
            }

            if (Input.GetMouseButtonDown(2) || OVRInput.Get(OVRInput.RawButton.Y))
            {
                jennyWalk();
            }

        }


        public void jennyHide()
        {
            jennyAni.Play("jennyHide");
        }

        public void jennyDeath()
        {

            jennyAni.Play("jennyDeath");
        }

        public void jennyAgony()
        {
            jennyAni.Play("jennyAgony");
        }

        public void jennyHurt()
        {
            jennyAni.Play("jennyHurt");
        }

        public void jennyArmAttack()
        {
            jennyAni.Play("jennyArmAttack");

        }

        public void jennyBiteAttack()
        {
            jennyAni.Play("jennyBiteAttack");
        }

        public void jennyFeast()
        {
            jennyAni.Play("jennyFeast");
        }


        public void jennyWalk()
        {
            jennyAni.Play("jennyWalk");
            jennyAni.SetBool("jennyWalk", true);
        }



    }