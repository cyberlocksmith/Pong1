using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Vid 5B
public class Ball : MonoBehaviour {
	public float ballSpeed ; //set in Unity, was: = 100.5f
	public Rigidbody ballRigidbody;
	public GameManager gameManager;
	void Start () {
		ballRigidbody.velocity = new Vector3 (ballSpeed, 10.0f, 0.0f);
	}

	void Update (){
		
	}

	void OnTriggerEnter (Collider triggeredWith){
		print (triggeredWith);
		print (triggeredWith.tag);

		if (triggeredWith.tag == "leftGoalTag") {
			gameManager.UpdaterightPlayer ();
			print ("Left Player Scored");
		}
		else if (triggeredWith.tag == "rightGoalTag") {
			gameManager.UpdateleftPlayer ();
			print ("Right Player Scored");
		}
			
	}




	/*
	float ballSpeed = 20.5f;  //us f to insure its a float
	float x = 10.0f;
	float y = 0.000001f;
	const float z = 0.0f;
	public Rigidbody ballRigidbody;
	// Use this for initialization
	void Start () {
		print (ballSpeed);
		//ballRigidbody.velocity = new Vector3 (ballSpeed,0f,0f);
		ballRigidbody.velocity = new Vector3 (x,y,z);		
	}
	void Update () {
		print (ballRigidbody.velocity);
	}

	*/


}
