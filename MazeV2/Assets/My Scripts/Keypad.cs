using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour {
 
    public string curPassword = "12345";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
	public bool key1;
	public bool key2;
	public bool key3;
	public bool key4;
	public bool opened;
	public Animation anim;
 
 void Start()
    {
		key1 = false;
		key2 = false;
		key3 = false;
		key4 = false;
        anim = gameObject.GetComponent<Animation>();
    }
 
    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
		input = "";
 
    }
 
    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }
 
    void Update()
    {
 
        if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            input = input + "0";
        }
 
 
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            input = input + "1";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            input = input + "2";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            input = input + "3";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            input = input + "4";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            input = input + "5";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            input = input + "6";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            input = input + "7";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            input = input + "8";
        }
 
        if(Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            input = input + "9";
        }
		//if(key1 == true && key2 == true && key3 == true && key4 == true){
		 if(key1 == true && key2 == true && key3 == true && key4 == false){
			keypadScreen = false;
			opened = true;
			doorOpen = true;
			key1 = false;
			key2 = false;
			key3 = false;
			key4 = false;
			onTrigger = false;
			
		}
 
 
        if(input == curPassword)
        {
			onTrigger = false;
            doorOpen = true;
			keypadScreen = false;
			input = "";
        }
 
        if(doorOpen)
        {
            //anim.Play("Door_Open");
			//var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 250);
            //doorHinge.rotation = newRot;
			//object.Rotate(0,  90, 0);
			onTrigger = false;
			transform.Rotate(0, 0, 90);
			input = "";
			keypadScreen = false;
			
			doorOpen = false;
           // bodka.SetActive (false);
 
 
        }
    }
 /*
    void OnGUI()
    {
        if(!doorOpen)
        {
            if(onTrigger)
            {
                GUI.Box(new Rect(0, 0, 400, 50), "'E' to open keypad");
 
                if(Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }
 
            if(keypadScreen)
            {
                GUI.Box(new Rect(0, 0, 640, 70), "");
                GUI.Box(new Rect(10, 10, 620, 50), input);
                GUI.Label(new Rect(10, 60, 200, 50), "'Esc' to exit");
 
                if(Input.GetKeyDown(KeyCode.Escape))
                {
 
                    keypadScreen = false;
					input="";
                }              
 
 
            }
        }
    }
	*/
}
