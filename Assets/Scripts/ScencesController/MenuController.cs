﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		
	}

	public void startGame(){
		SceneManager.LoadScene ("PlayScence");
	}
}
