using UnityEngine;
using System.Collections;

public class DestroyBullets : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D( Collision2D bullet){
		if (bullet.gameObject.tag == "Bullet") {
			Destroy (bullet.gameObject);
		}

	}
}
