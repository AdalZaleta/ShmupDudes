using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting_Menu : MonoBehaviour {

	public GameObject lit;
	public float vel;
	public float litvel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lit.transform.Rotate (Vector3.up * litvel, Space.World);
		transform.Rotate (Vector3.up * vel, Space.World);
	}
}
