using UnityEngine;
using System.Collections;

public class Player4Move : MonoBehaviour {

	public float moveVar = 10;
	public float turnVar = 200;
	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = Color.blue;

	}
	
	// Update is called once per frame
	void Update () {
		
		float move = (Input.GetAxis("Player4Vert"))*Time.deltaTime*moveVar;		
		float turn = (Input.GetAxis("Player4Horiz"))*Time.deltaTime*turnVar;
			
		//transform.Translate(0,0,move);
		transform.Rotate(0,turn,0);
		transform.Translate(0,0,move); 
		//rigidbody.AddRelativeForce(turn,0,0);	
	}
}
