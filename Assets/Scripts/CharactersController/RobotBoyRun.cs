using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBoyRun : MonoBehaviour {

	public float forceY;
	public Animator anim;
	private bool isAlive,isJump;
	public bool isGround;
	public Transform startPos,colBot;
	public static RobotBoyRun instance;
	public int score;

	[SerializeField]
	private Rigidbody2D body;


	void Awake(){
		isAlive = true;
		anim = GetComponent<Animator> ();
		if (instance == null)
			instance = this;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isAlive){
			isGround = Physics2D.Linecast (startPos.position,colBot.position,1 << LayerMask.NameToLayer("layerground"));
			if (isJump)
				_characterJump ();
			if (!isGround)
				anim.Play ("Jump");
			else
				anim.Play ("Run");
		}
	}

	public void pressJump(){
		isJump = true;
	}

	void _characterJump(){
		body.velocity = new Vector2 (2f,forceY);
		isJump = false;
	}
	/*
	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Ground")
			anim.Play ("Run");
	}
	*/
}
