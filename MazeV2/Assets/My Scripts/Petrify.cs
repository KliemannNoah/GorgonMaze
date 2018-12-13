
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Petrify : MonoBehaviour {

    public AudioSource petrifySound;
    //public GameObject source;
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

    void Update()
    {
        if (petrifying)
        {
            health -= healthMod;
        }
        if (health > 0)
        {
            uiPiece.text = "Current Health: " + health;
        }
        else
        {
            uiPiece.text = "You Lose!";
            StartCoroutine(ExecuteAfterTime(3));
            
        }
    }
    void OnCollisionEnter(Collision col)
    {
	    petrifySound.Play(0);
        animator.Play("jennyArmAttack");
        petrifying = true;
    }

    void OnCollisionExit(Collision col)
    {
	petrifySound.Stop();
        petrifying = false;
    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Level 2");

    }
}
