using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button4 : MonoBehaviour {

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
			//keypad.key4= true;
				keypad.key1 = false;
				keypad.key2 = false;
				keypad.key3 = false;
				keypad.key4 = false;
			doorIsOpening = false;
		}
	}
	
	void OnCollisionEnter(Collision other){
			doorIsOpening = true;
            m_Collider.enabled = !m_Collider.enabled;
            transform.Translate(Vector3.forward * .9f);
			StartCoroutine(ExecuteAfterTime(10));
			

	}
	
	IEnumerator ExecuteAfterTime(float time){
		yield return new WaitForSeconds(time);
        m_Collider.enabled = !m_Collider.enabled;

        transform.Translate(Vector3.forward * -.9f);
		
	}
	//void OnMouseDown(){
	//	doorIsOpening = true;
	//}
}