using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
	private int leftscore;
	private int rightscore;
	private TextMesh t;
	// Use this for initialization
	void Start () {
		leftscore = 0;
		rightscore = 0;
		t = (TextMesh)gameObject.GetComponent (typeof (TextMesh));
		updateText ();
	}

	void updateText() {
		t.text = "Score Left: " + leftscore.ToString () + " Score Right: " + rightscore.ToString ();
	}

	// Update is called once per frame
	public void UpdateLeftScore (int update) {
		leftscore = leftscore + update;
		updateText ();
	}

	public void UpdateRightScore (int update) {
		rightscore = rightscore + update;
		updateText();
	}
}
