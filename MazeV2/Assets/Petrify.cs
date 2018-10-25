using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///I get the feeling this is going to have to be entirely raycasting
///Which makes sense but still, feels bad man
/// 5:38pm 10/25/18


public class Petrify : MonoBehaviour {
    public GameObject playerL;
    public GameObject playerR;
    public TextMesh uiPiece;
    bool petrifyOn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(petrifyOn){uiPiece.text = "Uh oh.";}
	}


	void OnCollisionEnter(Collision collision){
     if (collision.gameObject.name == playerL.name || collision.gameObject.name == playerR.name){
        petrifyOn = true;
     }
 }

}
