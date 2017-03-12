using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController2 : MonoBehaviour {
	Rigidbody2D rigid;
	public float speed;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(speed,0));
		//		rigid.AddForce (new Vector2 (speed, 0));
	}
}
