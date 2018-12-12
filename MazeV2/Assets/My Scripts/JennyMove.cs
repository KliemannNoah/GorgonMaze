using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JennyMove : MonoBehaviour {


    //controller for all Jenny movements
    public Animator jennyAni;
    public Transform target;
    public float xRange = 0.1f;
    public float zRange = 0.1f;
    public float speed = 2;
    bool walking = false;
    float step;
    
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
    void Start () {
        jennyAgony();
    }
	
	// Update is called once per frame
	void Update () {

        if (walking)
        {
            if (Mathf.Abs(transform.position.x - target.position.x)< xRange && Mathf.Abs(transform.position.z - target.position.z) < zRange)
            {
                walking = false;
            }
            else
            {
                step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
           
        }
      


        if (Input.GetMouseButtonDown(0) || OVRInput.Get(OVRInput.RawButton.Y) )
        {
            jennyArmAttack();
            jennyAgony();
        }

        if (Input.GetMouseButtonDown(1) || OVRInput.Get(OVRInput.RawButton.X))
        {
            jennyWalk();
            
        }

        if (Input.GetMouseButtonDown(2) || OVRInput.Get(OVRInput.RawButton.X))
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
        target.position = new Vector3 (target.position.x, -0.8f, target.position.z);

        walking = true;
    }



}
