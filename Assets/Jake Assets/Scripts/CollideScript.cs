using UnityEngine;
using System.Collections;


public class CollideScript : MonoBehaviour {
	
	//Method that detects first collision with rigid bodies
	void OnCollisionEnter(Collision collision) {
		//defines the contact object that contains point and the two collider objects
		//point: point of contact
		//thisCollider: the object that collided 
		//otherCollider: the object that it collided in to
        foreach (ContactPoint contact in collision.contacts) {
			if(collision.gameObject.tag == "Enemy")
            	Debug.Log("Collision on enemy");
			else
				Debug.Log ("Collision on object");
			Debug.Log (contact.point);
			Debug.Log (contact.thisCollider);
			Debug.Log (contact.otherCollider);
        }
    }
}