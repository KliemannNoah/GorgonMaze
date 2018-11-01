using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://forum.unity.com/threads/how-can-you-detect-but-still-physically-ignore-collisions.111583/
//Collider -> Trigger fix by Eric5h5 on the above link


public class Petrify : MonoBehaviour {

    public GameObject source;
    public GameObject playerL;
    public GameObject playerR;
    public TextMesh uiPiece;
    private Vector3 lastPosition = new Vector3();
    private Vector3 lastVelocity = new Vector3();
    private Vector3 lastAngularVelocity = new Vector3();

    // Use this for initialization
    void Start () {
        source.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        lastPosition = transform.position;
        lastVelocity = GetComponent<Rigidbody>().velocity;
        lastAngularVelocity = GetComponent<Rigidbody>().angularVelocity;

    }

    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        transform.position = lastPosition;
        GetComponent<Rigidbody>().velocity = lastVelocity;
        GetComponent<Rigidbody>().angularVelocity = lastAngularVelocity;
        Physics.IgnoreCollision(GetComponent<Collider>(), col.collider);

        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "LeftControllerScriptAlias" || col.gameObject.name == "RightControllerScriptAlias" || col.gameObject.name == "VRSimulator_CameraRig")
        {

            uiPiece.text = "Oh dear.";
        }

    }

    void OnCollisionExit(Collision col)
    {
            //TODO: move to exit
            uiPiece.text = "All good.";
    }

}
