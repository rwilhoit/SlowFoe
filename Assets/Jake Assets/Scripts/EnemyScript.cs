using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int size = 1; 
	// Use this for initialization
	void Start () {
 		 transform.localScale += new Vector3(size/2F, size/2F, size/2F);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
