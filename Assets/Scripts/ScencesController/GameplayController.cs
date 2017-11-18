using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Text textScore;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(RobotBoyRun.instance != null)
			textScore.text = "Score : " + RobotBoyRun.instance.score;
	}
}
