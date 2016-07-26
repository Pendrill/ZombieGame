using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			int currentSceneNumber = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene (currentSceneNumber);

		}
	}
}
