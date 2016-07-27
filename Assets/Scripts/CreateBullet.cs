using UnityEngine;
using System.Collections;

public class CreateBullet : MonoBehaviour {
	public Transform spawner;
	public GameObject bullet;
	GameObject player;
	Transform playerT;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerT = player.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate(bullet, spawner.position, playerT.rotation);
		}
	}
}
