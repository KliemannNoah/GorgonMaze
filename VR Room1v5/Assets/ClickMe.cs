 using UnityEngine;
 using System.Collections;
 
 public class ClickMe : MonoBehaviour {
 
     private bool doorOpen = false;
     private float animationFinished = 0;
	 Animator animation;
	
	 void Start(){
		 animation = GetComponent<Animator>();
	 }
     public void OnMouseUp()
     {
         Debug.Log ("Ive been clicked");
 
         if(Time.time > animationFinished)
         {
             if(doorOpen)
             {
                 animation.Play("CloseDoor");
             }
             else
             {
                 animation.Play("OpenDoor");
             }
 
             animationFinished = Time.time + 1;
             doorOpen = !doorOpen;
         }
     }
 }