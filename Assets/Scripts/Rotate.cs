using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (player.GetComponent<Transform> ().position, player.GetComponent<Transform> ().position, 200 * Time.deltaTime);
	}
}
