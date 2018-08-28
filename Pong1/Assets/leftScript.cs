using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftScript : MonoBehaviour {
	public GameObject manager;
	private GameManager managerO;
	// Use this for initialization
	void Start () {
		managerO = (GameManager)manager.GetComponent (typeof(GameManager));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit(Collision other)
	{
		print("No longer in contact with " + other.transform.name);
		managerO.UpdateleftPlayer();
	}

}
