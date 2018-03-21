using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]

public class Movement_3DSprite : MonoBehaviour {

	Vector3 rigVel;
	Rigidbody rig;
	public float vel;
	public Camera _cam;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			rigVel.z = vel;
		} else if (Input.GetKey (KeyCode.S)) {
			rigVel.z = -vel;
		} else
			rigVel.z = 0;

		if (Input.GetKey (KeyCode.A)) {
			rigVel.x = -vel;
		} else if (Input.GetKey (KeyCode.D)) {
			rigVel.x = vel;
		} else
			rigVel.x = 0;

		rigVel.y = rig.velocity.y;

		rig.velocity = rigVel;

		//transform.LookAt (_cam.transform);
	}
}
