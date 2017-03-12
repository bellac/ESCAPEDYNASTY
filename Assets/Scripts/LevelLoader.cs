using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;
	public string levelToLoad;

	// Use this for initialization
	void Start () {
		playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)&&playerInZone) {
			Application.LoadLevel (levelToLoad);
			Debug.Log ("bbbb");
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			playerInZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			playerInZone = false;
		}
	}
}
