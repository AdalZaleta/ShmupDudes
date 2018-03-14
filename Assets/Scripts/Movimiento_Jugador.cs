using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour {

	public float Xaxis;
	public float Yaxis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Xaxis = Input.GetAxis ("Horizontal");
		Debug.Log (Xaxis);
	}
}
