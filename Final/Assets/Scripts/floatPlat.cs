using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatPlat : MonoBehaviour {


	public Transform Spawn;
	public GameObject Tile;
	// Use this for initialization
	void Start () {
		Instantiate (Tile, Spawn.position, Spawn.rotation);

	}

	// Update is called once per frame
	void Update () {

	}


}
