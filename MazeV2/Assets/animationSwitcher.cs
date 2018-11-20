using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSwitcher : MonoBehaviour {

    public Animator jennyAnimation;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Animation 'hurt' should be playing.");
            jennyAnimation.SetBool("jennyHurt", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Animation 'hurt' should be playing.");
            jennyAnimation.SetBool("jennyAttack", true);
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Animation 'hurt' should be playing.");
            jennyAnimation.SetBool("jennyHide", true);
        }



    }
}
