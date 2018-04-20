using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene ("TempResart", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
