using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	Transform target; //the enemy's target
	int moveSpeed = 6; //move speed
	int rotationSpeed = 6; //speed of turning
	 
	Transform myTransform; //current transform data of this enemy
	 
	void Awake() {
	    myTransform = transform; //cache transform data for easy access/preformance
	}
	 
	void Start() {
	 	//target = GameObject.FindWithTag("Player1").transform; //target the player
	}
	
	void OnTriggerEnter (Collider colliderInfo)	{
		
		Debug.Log("CollisionEnemyScript: " + colliderInfo.gameObject.transform.parent.gameObject.transform.position);
		target = GameObject.FindWithTag("Player1").transform; //target the player

	}
	
	void OnTriggerStay (Collider colliderInfo) {
		Debug.Log(colliderInfo);
		if(colliderInfo.tag == "Collider3")
			FollowPlayer();
	}
	
	void OnTriggerExit (Collider colliderInfo) {

	}
	
	void FollowPlayer () {
		if(target != null) {
			Debug.Log("Target position: " + target.position);
			Debug.Log("myTransform position: " + myTransform.position);
			
		    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
		    Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		 
		    //move towards the player
		    myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
	}
	 
	void Update () {
	    //rotate to look at the player
		
		
	}
}
