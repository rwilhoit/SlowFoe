using UnityEngine;
using System.Collections;


public class TestScript : MonoBehaviour {
	
	public Vector3 enemyPos = new Vector3();
	public Player1script player1script; 
	
	//Method that detects first collision with rigid bodies
	void OnCollisionEnter(Collision collision) {
		
        foreach (ContactPoint contact in collision.contacts) {
			
			Debug.Log ("Test script collision this is: " + contact.thisCollider);
			if(collision.gameObject.tag == "Enemy") {
            	Debug.Log("Collision on enemy");
			}
			else {
				//Debug.Log ("Collision on object");
			}
        }
    }
	
	void OnTriggerEnter(Collider colliderInfo) {
		if(colliderInfo.gameObject.tag == "Enemy") {
			Debug.Log("Test script Trigger on Enemy");
			Debug.Log(colliderInfo.gameObject.rigidbody.position);
			
			GameObject player1 = GameObject.Find ("SphereAI");
			Player1script player1script = player1.GetComponent<Player1script>();
			player1script.MoveTowardsEnemy();		
		}
	}
	
	void OnTriggerStay(Collider colliderInfo) {
		if(colliderInfo.gameObject.tag == "Enemy") {
			Debug.Log(colliderInfo.gameObject.rigidbody.position);
			enemyPos = colliderInfo.gameObject.rigidbody.position;
		}
		
	}
	
	public Vector3 GetEnemyPos() {
		return enemyPos;
	}
		
		
}