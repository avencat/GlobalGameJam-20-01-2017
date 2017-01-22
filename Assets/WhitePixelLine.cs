using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePixelLine : MonoBehaviour {

	public Vector3 offset = new Vector3(0f, -1f, 0f);
	Transform mainPlayer;

	// Start is called to initialize the object
	void Start () {
		mainPlayer = GameObject.Find ("Sphere").transform;
		gameObject.transform.position = mainPlayer.position;
	}

	// Update is called once per frame
	void Update () {
		Vector3 screenPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		transform.position = gameObject.transform.position + offset;
		if (screenPos.x <= 0)
			Destroy (gameObject);
	}
}
