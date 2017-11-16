using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Transform player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x+3,0,-10);
	}
}
