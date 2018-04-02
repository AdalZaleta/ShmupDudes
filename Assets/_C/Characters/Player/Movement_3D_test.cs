using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class Movement_3D_test : MonoBehaviour {

	float XRaxis;
	float YRaxis;
	float Xaxis;
	float Yaxis;
	float Aim;
	GameObject _aim;

	public float vel;

	Vector3 rigVel;

	Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
		_aim = GameObject.Find ("aim");
	}
	
	// Update is called once per frame
	void Update () {

		Xaxis = Input.GetAxis ("Horizontal");
		Yaxis = Input.GetAxis ("Vertical");

		XRaxis = Input.GetAxis ("RightStick H");
		YRaxis = Input.GetAxis ("RightStick V");

		rigVel.x = Xaxis * vel;
		rigVel.z = Yaxis * vel;
		rigVel.y = rig.velocity.y;

		rig.velocity = rigVel;

		rig.rotation = Quaternion.identity;

		if (XRaxis != 0.0f || YRaxis != 0.0f) 
		{
			Aim = Mathf.Atan2 (YRaxis, XRaxis) * Mathf.Rad2Deg;
		}

		_aim.transform.rotation = Quaternion.AngleAxis (Aim, Vector3.up);
	}
}
