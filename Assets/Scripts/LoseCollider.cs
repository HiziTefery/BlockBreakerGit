using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D collision) {
		print ("Collision");
	}
	public void OnTriggerEnter2D(Collider2D other) {
		print("Trigger");
		levelManager.LoadLevel("Win Screen");
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
}
