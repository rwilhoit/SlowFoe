using UnityEngine;
using System.Collections;

public class CollisionEnemyScript : MonoBehaviour {

	public Color collider3Color = Color.yellow;
	public Color collider2Color = new Color(1F, 0.5F, 1F); //Orange
	public Color collider1Color = Color.red;
		
	public int numOfTriggers = 0;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void updateColor(Color newColor) {
		gameObject.renderer.material.color = newColor;
	}
	
	
	
	void OnTriggerEnter (Collider colliderInfo)	{
		
		Debug.Log("CollisionEnemyScript: " + colliderInfo.gameObject.transform.parent.gameObject.transform.position);
		
		if(colliderInfo.gameObject.tag == "Collider1") {
			updateColor(collider1Color);
		}
		else if(colliderInfo.gameObject.tag == "Collider2") {
			updateColor(collider2Color);
		}
		else if(colliderInfo.gameObject.tag == "Collider3") {
        	updateColor(collider3Color);
		}
	}
	
    void OnTriggerStay(Collider colliderInfo) {
		
		//log current position of player in while in collider
		Debug.Log("CollisionEnemyScript: " + colliderInfo.gameObject.transform.parent.gameObject.transform.position);

    }
	
	void OnTriggerExit(Collider colliderInfo) {
		if(colliderInfo.gameObject.tag == "Collider1") {
			updateColor(collider2Color);
		}
		else if(colliderInfo.gameObject.tag == "Collider2") {
			updateColor(collider3Color);
		}
		else if(colliderInfo.gameObject.tag == "Collider3") {
        	updateColor(Color.white);
		}
	}
	
	void OnCollisionEnter (Collision collisionInfo) {
		if (collisionInfo.gameObject.tag == "Player") {
			updateColor(Color.black);	
		}
	}
	
	void OnCollisionStay (Collision collisionInfo) {

    }
	
	void OnCollisionExit (Collision collisionInfo) {
		if (collisionInfo.gameObject.tag == "Player") {
			updateColor(Color.red);
		}
	}
}
