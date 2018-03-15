using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

	GameObject player;
	Vector3 CharPos;
	public float zoom;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Character_A");
	}
	
	// Update is called once per frame
	void Update () {
		CharPos.x = player.transform.position.x;
		CharPos.y = player.transform.position.y;
		CharPos.z = zoom;
		transform.position = CharPos;
		transform.rotation = player.transform.rotation;
	}
}
