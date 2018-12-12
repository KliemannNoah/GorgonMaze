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
    public GameObject Jenny;
    public GameObject TV1;
    public GameObject TV2;
    public GameObject TV3;
    public GameObject TV4;
    public GameObject TV5;
    public GameObject TV6;
    public GameObject TV7;
    public GameObject TV8;
    public GameObject TV9;
    public GameObject TV10;


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
            //Instantiate(Jenny);

            Destroy(TV1);
            Destroy(TV2);
            Destroy(TV3);
            Destroy(TV4);
            Destroy(TV5);
            Destroy(TV6);
            Destroy(TV7);
            Destroy(TV8);
            Destroy(TV9);
            Destroy(TV10);

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
