using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Petrify : MonoBehaviour {

    public AudioSource petrifySound;
    public GameObject source;
    public GameObject playerL;
    public GameObject playerR;
    public TextMesh uiPiece;

    public Animator animator;

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
	petrifySound.Play(0);
   animator.SetBool("jennyAttack", true);
    petrifying = true;
        Debug.Log("Colliding!");
    }

    void OnCollisionExit(Collision col)
    {
	petrifySound.Pause();
        petrifying = false;
    }

}
