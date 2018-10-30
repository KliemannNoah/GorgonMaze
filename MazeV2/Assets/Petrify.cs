using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petrify : MonoBehaviour {

    public GameObject source;
    public GameObject playerL;
    public GameObject playerR;
    public TextMesh uiPiece;

	// Use this for initialization
	void Start () {
        source.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        
        
 }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == playerL.name || col.gameObject.name == playerR.name)
        {
            Debug.Log(col.gameObject.name);
            uiPiece.text = "Oh dear.";
        }
        else
        {
            //TODO: move to exit
            uiPiece.text = "All good.";
        }
    }



}
