using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {

	public float speed;

	public Player player;

//	public GameObject enemyDeathEffect;

	private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {

		player = FindObjectOfType<Player>();

		if (player.transform.localScale.x < 0)
			speed = -speed;

		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		myRigidbody.velocity = new Vector2 (speed, myRigidbody.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy") {
//			Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
		}
		Destroy (gameObject);
	}

}
