using UnityEngine;
using System.Collections;

public class escape : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown ("escape")) {
			print ("escape key was pressed");
			Application.LoadLevel ("menu");
		}
	}
}
