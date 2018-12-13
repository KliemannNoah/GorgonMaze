using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public GameObject Door;
    public bool doorIsOpening;
    private Keypad keypad;

    // Use this for initialization
    void Start () {
        keypad = Door.GetComponent<Keypad>();
    }
	
	// Update is called once per frame
	void Update () {
        if (keypad.opened)
        {
            Destroy(gameObject);
        }
	}

 

}
