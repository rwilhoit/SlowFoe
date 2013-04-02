using UnityEngine;
using System.Collections;

public class Player1script : MonoBehaviour {

	public float moveVar = 5;
	public float turnVar = 200;
	public float speed = 6.0f;			//Acceleration of slime
	public int 	maxSpeed = 15;			//Max velocity
	
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

 
	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		
		float move = (Input.GetAxis("Vertical"))*Time.deltaTime*moveVar;		
		float turn = (Input.GetAxis("Horizontal"))*Time.deltaTime*turnVar;
		transform.Rotate(0,turn,0);
		transform.Translate(0,0,move); 
		
		/*
		Vector3 inVec = new Vector3(0, 0, Input.GetAxis("Vertical"));
		
		//Adds velocity depending on inputted direction
		Vector3 change = inVec * Time.deltaTime * speed;
		
		//Adds the new velocity only if it doesn't go over max speed
		rigidbody.velocity += (rigidbody.velocity + change).magnitude < maxSpeed ? change : new Vector3(0f,0f,0f);
		
		float turn = (Input.GetAxis("Horizontal"))*Time.deltaTime*turnVar;
		transform.Rotate(0,turn,0);
		*/
		//Forces the slime to only face the direction of movement
		//transform.LookAt(transform.position + rigidbody.velocity);
		
	
	}
	
}
