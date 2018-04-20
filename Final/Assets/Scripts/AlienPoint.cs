using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienPoint : MonoBehaviour {

	public float speed;
	public bool GoingUp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GoingUp == true) {
			transform.position += transform.up * speed * Time.deltaTime;
		} else {
			transform.position -= transform.up * speed * Time.deltaTime;
		}
	


	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Waypoint") {
			if (GoingUp == true) {
				GoingUp = false;
			} else {
				GoingUp = true;
			}
		}
	}
}
