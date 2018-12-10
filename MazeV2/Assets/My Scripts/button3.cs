using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;
	private Keypad keypad;
    Collider m_Collider;

    // Use this for initialization
    void Start () {
		keypad = Door.GetComponent<Keypad>();
        m_Collider = GetComponent<Collider>();
        //var myScript Keypad = GetComponent.<Keypad>();
    }
	
	// Update is called once per frame
	void Update () {
		if (doorIsOpening){
			//keypad.key3= true;
			if(keypad.key1 == true && keypad.key2 == true && keypad.key3 == false && keypad.key4 == false)
            {
				keypad.key3 = true;
			}else{
				keypad.key1 = false;
				keypad.key2 = false;
				keypad.key3 = false;
				keypad.key4 = false;
			}
			doorIsOpening = false;
		}
	}
	
	void OnCollisionEnter(Collision other){
			doorIsOpening = true;
        m_Collider.enabled = !m_Collider.enabled;
        transform.Translate(Vector3.forward * .9f);
			StartCoroutine(ExecuteAfterTime(3));
			

	}
	
	IEnumerator ExecuteAfterTime(float time){
		yield return new WaitForSeconds(time);
		transform.Translate(Vector3.forward * -.9f);
        m_Collider.enabled = !m_Collider.enabled;
    }
	//void OnMouseDown(){
	//	doorIsOpening = true;
	//}
}