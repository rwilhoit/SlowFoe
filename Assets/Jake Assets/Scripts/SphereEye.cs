using UnityEngine;
using System.Collections;

public class SphereEye : MonoBehaviour {
	
    void Awake() {
        renderer.material.color = Color.green;
    }
    void OnDestroy() {
        DestroyImmediate(renderer.material);
    }
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
