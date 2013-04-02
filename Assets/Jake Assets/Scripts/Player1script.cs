using UnityEngine;
using System.Collections;

public class Player1script : MonoBehaviour {

	public float moveVar = 5;
	public float turnVar = 200;
 
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
	
	}
	
	public void MoveTowardsEnemy() {
				
		Vector3 enemyPos = this.GetComponent<CollideScript>().GetEnemyPos();
		Debug.Log("TEST Entered MoveTowardsEnemy");
		Debug.Log ("EnemyPos is: " + enemyPos);
		Debug.Log ("PlayerPos is: " + transform.position);
		//transform.Translate (enemyPos.x + transform.position.x,enemyPos.y + transform.position.y,enemyPos.z + transform.position.z);
	}
	
	
}
