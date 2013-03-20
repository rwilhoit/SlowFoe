using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveVar = 10;
	public float turnVar = 200;
	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = Color.blue;

	}
	
	// Update is called once per frame
	void Update () {
		
		float move = (Input.GetAxis("Vertical"))*Time.deltaTime*moveVar;		
		float turn = (Input.GetAxis("Horizontal"))*Time.deltaTime*turnVar;
			
		//transform.Translate(0,0,move);
		transform.Rotate(0,turn,0);
		transform.Translate(0,0,move); 
		//rigidbody.AddRelativeForce(turn,0,0);	
	}
}
