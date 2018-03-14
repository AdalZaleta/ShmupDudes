using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour {

	public float Xaxis;
	public float XRaxis;
	public float VelX;
	public float Yaxis;
	public float YRaxis;
	public float VelY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Xaxis = Input.GetAxis ("Horizontal");
		Yaxis = Input.GetAxis ("Vertical");

		XRaxis = Input.GetAxis ("RightStick H");
		YRaxis = Input.GetAxis ("RightStick V");

		gameObject.transform.Translate (Vector3.right * Time.deltaTime * Xaxis * VelX);
		gameObject.transform.Translate (Vector3.forward * Time.deltaTime * Yaxis * VelY);

		gameObject.transform.Rotate ()
	}
}
