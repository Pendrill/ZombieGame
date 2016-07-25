using UnityEngine;
using System.Collections;

public class ZombieFollow : MonoBehaviour {

	public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, player.position) > 0.1f) {
			transform.position += Vector3.Normalize (player.position - transform.position) * Time.deltaTime;
		}
	}
	void OnDrawGizmos(){
		Gizmos.DrawLine (transform.position, player.position);
	}
}
