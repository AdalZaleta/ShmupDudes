using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Simple : MonoBehaviour {

	public float vel;
	Rigidbody2D rig;
	public GameObject pellet;
	public GameObject Aim;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 rigVel = rig.velocity;
		if (Input.GetKey (KeyCode.A)) 
			rigVel.x = -vel;
			
		else if (Input.GetKey(KeyCode.D))
			rigVel.x = vel;
		else
			rigVel.x = 0;
			
		if (Input.GetKey(KeyCode.W))
			rigVel.y = vel;

		else if (Input.GetKey(KeyCode.S))
			rigVel.y = -vel;
		else
			rigVel.y = 0;

		rig.velocity = rigVel;

		if (Input.GetKey(KeyCode.E))
			Aim.transform.Rotate (Vector3.back * vel);
		if (Input.GetKey(KeyCode.Q))
			Aim.transform.Rotate (Vector3.forward * vel);
	}
}
