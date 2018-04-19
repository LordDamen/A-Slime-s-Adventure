using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour {
	Animator Anim;


	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float Movement = Input.GetAxis ("Horizontal");
		Anim.SetFloat("speed",Mathf.Abs(Movement));
	}
}
