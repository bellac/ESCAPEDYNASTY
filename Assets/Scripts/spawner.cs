 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject deathStuff;
	public float t;
	public float maxTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (t < 0) {
			Instantiate (deathStuff, transform);
			Debug.Log ("ssss");
			t = maxTime;
		}
		t--;
	}
}
