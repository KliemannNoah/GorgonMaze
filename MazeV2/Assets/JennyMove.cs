using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JennyMove : MonoBehaviour {


    //controller for all Jenny movements
    public Animator jennyAni;
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

        if (Input.GetMouseButtonDown(0))
        {
            jennyArmAttack();
        }

        if (Input.GetMouseButtonDown(1))
        {
            jennyHurt();
        }

        if (Input.GetMouseButtonDown(2))
        {
            jennyBiteAttack();
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



}
