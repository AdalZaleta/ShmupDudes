using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

	GameObject player;
	Vector3 CharPos;
	public float zoom;
	float Xoffset;
	float Yoffset;
	float Zoffset;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Character_A");
		Xoffset = transform.position.x;
		Yoffset = transform.position.y;
		Zoffset = transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
		if (player)
		{
			CharPos.x = player.transform.position.x + Xoffset;
			CharPos.y = player.transform.position.y + Yoffset;
			CharPos.z = player.transform.position.z + Zoffset;
			transform.position = CharPos;
		}
	}
}
