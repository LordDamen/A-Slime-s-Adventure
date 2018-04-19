using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public GameObject WinScreen;
	public GameObject GameOver;
	public GameObject CurrentGame;
	public int lives;
	public Vector3 LastCheckpoint;

	// Use this for initialization
	void Start () {
		LastCheckpoint = transform.position;
	}
	
	void OnTriggerEnter2D (Collider2D other ) {
		if (other.tag == "checkpoint")
		{
			LastCheckpoint = transform.position;
			Destroy (other.gameObject);
		}
		if (other.tag == "enemy") {
			if (lives > 0) {
				transform.position = LastCheckpoint;
				lives -= 1;
			}
			else {
				GameOver.SetActive (true);
				CurrentGame.SetActive (false);
			}
		}
		if(other.tag == "Win")
		{
			WinScreen.SetActive (true);
			CurrentGame.SetActive (false);
		}
	}

}