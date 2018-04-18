using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditbois : MonoBehaviour {

	public GameObject piv;
	public float vel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		piv.transform.Translate (Vector3.up * vel);
	}
}
