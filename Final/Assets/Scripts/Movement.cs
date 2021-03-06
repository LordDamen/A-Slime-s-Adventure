﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public int MaxJumps;
	public int PlayerSpeed;
	public int JumpHeight;
	public int JumpsLeft;
	public Rigidbody2D rb;
	public float GroundDistance;
	public bool IsFlipped;
	public bool IsGrounded;
	public GameObject Pause;
	public GameObject CurrentRunning;
	public LayerMask GroundArea;
	public AudioClip JumpSound;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

        // Visual Aspect
		//Debug.DrawRay (transform.position, Vector3.down * GroundDistance, Color.cyan);
		// checks if the player is grounded
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector3.down, GroundDistance, GroundArea);

		if (hit.collider != null) {
			IsGrounded = true;
			JumpsLeft = MaxJumps;
		} else {
			IsGrounded = false;
		}

		if (Input.GetKey ("left") || Input.GetKey(KeyCode.A))
			{
				transform.position -= transform.right *PlayerSpeed * Time.deltaTime;
				if (IsFlipped == false) 
				{
					transform.localScale = new Vector3 (transform.localScale.x *-1, transform.localScale.y,transform.localScale.z);
					IsFlipped = true;
				}
			}

		if (Input.GetKey ("right") || Input.GetKey(KeyCode.D)) 
				{
					transform.position += transform.right *PlayerSpeed * Time.deltaTime;
					if (IsFlipped == true) 
					{
						transform.localScale = new Vector3 (transform.localScale.x *-1, transform.localScale.y,transform.localScale.z);
						IsFlipped = false;
					}
				}
		if (Input.GetKeyDown ("up") || Input.GetKey(KeyCode.W)) 
			{
				if (JumpsLeft > 0) 
				{
					JumpsLeft = JumpsLeft -= 1;
					rb.velocity += JumpHeight * Vector2.up;
					//AudioSource.PlayClipAtPoint (JumpSound, transform.position);
				}
			}
		if (Input.GetKeyDown ("escape")) {


            if (!Pause.activeSelf)
            {
                Pause.SetActive(true);
            } else
            {
                Pause.SetActive(false);
            }
            if (!CurrentRunning.activeSelf)
            {
                CurrentRunning.SetActive(false);
            }
            else
            {
                CurrentRunning.SetActive(true);
            }
		}


	}
}
