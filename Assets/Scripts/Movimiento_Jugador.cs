using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour {

	public float Xaxis;
	public float XRaxis;
	public float Yaxis;
	public float YRaxis;
	public float Velocidad;
	public float AnguloR;

	// Use this for initialization
	void Start () {
		Velocidad = 4.3f;
	}
	
	// Update is called once per frame
	void Update () {
		Xaxis = Input.GetAxis ("Horizontal");
		Yaxis = Input.GetAxis ("Vertical");

		XRaxis = Input.GetAxis ("RightStick H");
		YRaxis = Input.GetAxis ("RightStick V");

		gameObject.transform.Translate (Vector3.right * Time.deltaTime * Xaxis * Velocidad, Space.World);
		gameObject.transform.Translate (Vector3.forward * Time.deltaTime * Yaxis * Velocidad, Space.World);

		if (XRaxis != 0.0f || YRaxis != 0.0f) 
		{
			AnguloR = Mathf.Atan2 (YRaxis, XRaxis) * Mathf.Rad2Deg;
		}
		//transform.Rotate ( Vector3.up * AnguloR, Space.World);

		Debug.Log (AnguloR);
		transform.rotation = Quaternion.AngleAxis (AnguloR, Vector3.up);
		//gameObject.transform.Rotate ();
	}
}
