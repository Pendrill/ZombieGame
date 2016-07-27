using UnityEngine;
using System.Collections;

public class ZombieFollow : MonoBehaviour {

	public GameObject player;
	public Transform playerT;
	public int ZombieSpeed;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerT = player.GetComponent<Transform> ();
		//ZombieSpeed = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Vector3.Distance (transform.position, playerT.position) > 0.1f) {
			transform.position += Vector3.Normalize (playerT.position - transform.position) * ZombieSpeed * Time.deltaTime;
		}
	}
	void OnDrawGizmos(){
		Gizmos.DrawLine (transform.position, playerT.position);
	}
}
