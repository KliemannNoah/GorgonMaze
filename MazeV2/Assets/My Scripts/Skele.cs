using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skele : MonoBehaviour {


    Collider m_Collider;

    // Use this for initialization
    void Start () {
        m_Collider = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision other)
    {
        
        m_Collider.enabled = !m_Collider.enabled;
        StartCoroutine(ExecuteAfterTime(10));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        m_Collider.enabled = !m_Collider.enabled;


    }
}
