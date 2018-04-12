﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	 void Awake() {
		 if (instance != null){
			Destroy (gameObject);
			print ("Duplicate object self-destroyed");
		}
		else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	} 

	// Update is called once per frame
	void Update () {
		
	}
}
