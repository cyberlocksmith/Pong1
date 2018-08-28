using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRacket : MonoBehaviour {
	public float racketSpeed = 5f;
	public Rigidbody racketRigidbody;

	public KeyCode playerUp;
	public KeyCode playerDown;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(playerUp)) {
			print ("Up Arrow");
			racketRigidbody.velocity = new Vector3 (0,racketSpeed,0);
		}
		else if (Input.GetKey(playerDown)) {
			print ("Down Arrow");
			racketRigidbody.velocity = new Vector3 (0,- racketSpeed,0);
		}
		else  {
			racketRigidbody.velocity = new Vector3 (0,0,0);
		}		
	}
}
