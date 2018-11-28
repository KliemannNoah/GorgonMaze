using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour {
	
	Animator doorOpenAnimation;
	
	private void OnTriggerEnter(Collider other){
		doorOpenAnimation.SetTrigger("Door_Open"); 
	}

}
