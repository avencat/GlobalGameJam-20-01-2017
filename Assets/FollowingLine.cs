using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingLine : MonoBehaviour {

	List<Vector3> positions = new List<Vector3>();
	public Vector3 offset = new Vector3(0f, 0, 0f);
	Vector3[] tab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		Vector3 screenPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		positions.Add(screenPos);
		for (int i = positions.Count - 1; i >= 0; i--)
		{
			if (positions[i].x <= 0)
				positions.RemoveAt(i);
		}
		var points = new Vector3[positions.Count];
		lineRenderer.numPositions = positions.Count;
		for (int x = 0; x < positions.Count; x++) {
			positions[x] = positions[x] + offset;
			points[x] = new Vector3(positions[x].x, positions[x].y, positions[x].z);
		}
		lineRenderer.SetPositions (points);
		tab = new Vector3[positions.Count];
		lineRenderer.GetPositions (tab);
	}
}
