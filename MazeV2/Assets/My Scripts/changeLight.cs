using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour {

	public GameObject Door;
	public Material[] material;
	Renderer rend;
	public bool change;
	private Keypad keypad;

	// Use this for initialization
	void Start () {
		keypad = Door.GetComponent<Keypad>();
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
		
	}
	
	void Update () {
		if(keypad.opened==true){
			change = true;
			rend.sharedMaterial = material[1];
		}
		
	}
}
