using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 lookDirection = cursorPositionInWorld - transform.position;
		lookDirection.z = 0f;
		transform.up = lookDirection;
	}
}
