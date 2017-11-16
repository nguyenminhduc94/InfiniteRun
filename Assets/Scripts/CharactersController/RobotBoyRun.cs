using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBoyRun : MonoBehaviour {

	public float forceY;
	private Animator anim;
	private bool isAlive,isJump;
	[SerializeField]
	private Rigidbody2D body;


	void Awake(){
		isAlive = true;
		anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isAlive) {
			if (isJump) {
				_characterJump ();
			}
		}
	}

	public void pressJump(){
		isJump = true;
		anim.Play ("Jump");
	}

	void _characterJump(){
		body.velocity = new Vector2 (0,forceY);
		isJump = false;
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Ground"){
			anim.Play("Run");
		}
	}
}
