using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBoyRun : MonoBehaviour {

	public float forceY;
	public Animator anim;
	private bool isAlive,isJump,isRoll;
	public bool isGround;
	public Transform startPos,colBot;
	public static RobotBoyRun instance;
	public int score;
	public float pos;

	[SerializeField]
	private Rigidbody2D body;


	void Awake(){
		isAlive = true;
		anim = GetComponent<Animator> ();
		if (instance == null)
			instance = this;
	}

	void Start () {
		pos = transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isAlive){
			isGround = Physics2D.Linecast (startPos.position,colBot.position,1 << LayerMask.NameToLayer("layerground"));
			if (isJump)
				_characterJump ();
			if (!isGround) {
				anim.Play ("Roll");
			} else {
				anim.Play ("Run");
			}
		}
	}

	public void pressJump(){
		isJump = true;
	}

	void _characterJump(){
		body.velocity = new Vector2 (2f, forceY);
		isJump = false;
	}
}
