using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	private Rigidbody2D myRigidbody;
	public float moveSpeed;
	public bool moveRight;

	public Transform wallCheck;
	public float wallcheckRadius;
	public LayerMask whatIsWall;
	private bool hittingwall;

	private bool notAtEdge;
	public Transform edgeCheck;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		hittingwall = Physics2D.OverlapCircle (wallCheck.position, wallcheckRadius, whatIsWall);
		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, wallcheckRadius, whatIsWall);

		if (hittingwall || !notAtEdge)
			moveRight = !moveRight;

		if (moveRight) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
			myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);
		} else {
			transform.localScale = new Vector3 (1f, 1f, 1f);
			myRigidbody.velocity = new Vector2 (-moveSpeed, myRigidbody.velocity.y);
		}
	}
}
