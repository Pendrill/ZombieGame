using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {
	private Rigidbody2D bulletRigidBody;
	public int moveSpeedBullet;
	// Use this for initialization
	void Start () {
		bulletRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bulletRigidBody.velocity = (transform.up * moveSpeedBullet)*Time.deltaTime;  
	}

	void OnTriggerEnter2D( Collider2D enemy){
		if (enemy.tag == "Zombie") {
			Destroy (enemy.gameObject);
			Destroy (gameObject);
		}
	}
}
