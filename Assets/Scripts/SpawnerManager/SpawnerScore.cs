using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScore : MonoBehaviour {

	[SerializeField]
	private GameObject score;
	// Use this for initialization
	void Start () {
		StartCoroutine (Clone());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Clone(){
		yield return new WaitForSeconds (1);
		Instantiate (score, transform.position, Quaternion.identity);
		StartCoroutine (Clone());
	}
}
