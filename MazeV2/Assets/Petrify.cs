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

    // Use this for initialization
    void Start () {
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
            uiPiece.text = "Oh dear.";
    }

    void OnCollisionExit(Collision col)
    {
            //TODO: move to exit
            uiPiece.text = "All good.";
    }

}
