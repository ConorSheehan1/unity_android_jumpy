using UnityEngine;
using System.Collections;
using System;

public class UserControls : MonoBehaviour {
	public Rigidbody2D rb;

	//space

	public Transform spaceCheck;
	public float spaceCheckRadius;
	public LayerMask isSpace;
	private bool inSpace;
	

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(3, rb.velocity.y);

		//onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRandius, isGround);
		inSpace = Physics2D.OverlapCircle(spaceCheck.position, spaceCheckRadius, isSpace);

		if (Input.GetMouseButtonDown(0)) {
			rb.velocity = new Vector2(rb.velocity.x, 3);
		}

		if (!inSpace) {
			FindObjectOfType<GameManager> ().EndGame();
			// game over
		}

	}
}
