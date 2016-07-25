using UnityEngine;
using System.Collections;

public class SpawnZombie : MonoBehaviour {

	public GameObject ZombieClone;
	public Transform spawner;
	public float delayTime=5f;
	public float spawnInterval=2f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("cloneZombie", delayTime, spawnInterval);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void cloneZombie(){
		Instantiate(ZombieClone, spawner.position , Quaternion.Euler(0f,0f,0f));
	}
}
