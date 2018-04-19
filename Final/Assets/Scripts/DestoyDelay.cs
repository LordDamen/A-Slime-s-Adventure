using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyDelay : MonoBehaviour {
	 
	public int delay;

	void OnTriggerExit2D (Collider2D other) {
		Destroy(gameObject, delay);
	}
}