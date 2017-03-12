using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody2D myRigidbody;
	public float moveSpeed;
	private float moveVelocity;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundcheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;



	// Use this for initialization
	void Start () 
	{
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundcheckRadius, whatIsGround);
	}
	// Update is called once per frame
	void Update () 
	{
		HandleMovement ();
	}
	private void HandleMovement()
	{
		if (grounded)
			doubleJumped = false;
		
		if (Input.GetKeyDown (KeyCode.Space)&& grounded) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpHeight);
		}
		if (Input.GetKeyDown (KeyCode.Space)&& !doubleJumped && !grounded) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpHeight);
			doubleJumped = true;
		}
		moveVelocity = 0f;
		if (Input.GetKey (KeyCode.RightArrow)) {
			
//			myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);
			moveVelocity = moveSpeed;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {

//			myRigidbody.velocity = new Vector2 (-moveSpeed,myRigidbody.velocity.y);
			moveVelocity = - moveSpeed;
		}
		myRigidbody.velocity = new Vector2 (moveVelocity, myRigidbody.velocity.y);
		if (myRigidbody.velocity.x > 0) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		} else if (myRigidbody.velocity.x < 0) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		}

	}
}
