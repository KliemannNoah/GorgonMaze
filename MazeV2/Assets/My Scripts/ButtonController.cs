using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (doorIsOpening){
			Door.transform.Rotate(0, 0, 90);
			doorIsOpening = false;
		}
	}
	void OnCollisionEnter(Collision other){
			//doorIsOpening = true;
	}
	//void OnMouseDown(){
	//	doorIsOpening = true;
	//}
}
