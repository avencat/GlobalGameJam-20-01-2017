using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopObjects : MonoBehaviour {

	public Transform whitePixel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		WhiteTrainee ();
	}

	void WhiteTrainee () {
		Instantiate (whitePixel);
	}
}
