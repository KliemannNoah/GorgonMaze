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

    public float health=100;
    public float healthMod = 1;
    private bool petrifying = false;

    // Use this for initialization
    void Start () {
    }

    void Update() {
        if (petrifying)
        {
            health -= healthMod;
        }
        uiPiece.text = "Current Health: " + health;
    }

    void OnCollisionEnter(Collision col)
    {
        petrifying = true;
    }

    void OnCollisionExit(Collision col)
    {
        petrifying = false;
    }

}
