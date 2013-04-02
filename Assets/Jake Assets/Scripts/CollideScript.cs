using UnityEngine;
using System.Collections;


public class CollideScript : MonoBehaviour {
	
	public Vector3 enemyPos = new Vector3();

	
	//Method that detects first collision with rigid bodies
	void OnCollisionEnter(Collision collision) {
		//defines the contact object that contains point and the two collider objects
		//point: point of contact
		//thisCollider: the object that collided 
		//otherCollider: the object that it collided in to
		
        foreach (ContactPoint contact in collision.contacts) {
			
			Debug.Log ("Collision this is: " + contact.thisCollider);
			if(collision.gameObject.tag == "Enemy") {
            	Debug.Log("Collision on enemy");
			}
			else {
				//Debug.Log ("Collision on object");
			}
        }
    }
	
	void OnTriggerEnter(Collider colliderInfo) {
		if(colliderInfo.gameObject.tag == "Enemy")
			Debug.Log("Trigger on Enemy");
		
			GameObject player1 = GameObject.Find ("Collider1");
			TestScript testScript = player1.GetComponent<TestScript>();
			enemyPos = testScript.GetEnemyPos();
	}
	
	public Vector3 GetEnemyPos() {
		return enemyPos;
	}
}