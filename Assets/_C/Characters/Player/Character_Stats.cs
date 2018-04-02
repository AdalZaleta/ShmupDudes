using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats : MonoBehaviour {

	public float HP;
	bool inviscooldown;
	public float cdtime;
	GameObject _char;

	void OnCollisionStay (Collision _col)
	{
		if (_col.gameObject.CompareTag("Enemy"))
		{
			if (!inviscooldown)
			{
				HP--;
				StartCoroutine (blink ());
				StartCoroutine (inviscool ());
			}
		}
	}

	// Use this for initialization
	void Start () {
		_char = GameObject.Find ("Character");
	}
	
	// Update is called once per frame
	void Update () {

		if (HP <= 0)
		{
			Destroy (gameObject);
		}
	}

	IEnumerator blink()
	{
		_char.GetComponent<SpriteRenderer> ().material.color = Color.red;
		yield return new WaitForSeconds (0.1f);
		_char.GetComponent<SpriteRenderer> ().material.color = Color.white;
		yield return new WaitForSeconds (0.1f);
		_char.GetComponent<SpriteRenderer> ().material.color = Color.red;
		yield return new WaitForSeconds (0.1f);
		_char.GetComponent<SpriteRenderer> ().material.color = Color.white;
	}

	IEnumerator inviscool()
	{
		inviscooldown = true;
		yield return new WaitForSeconds (cdtime);
		inviscooldown = false;
	}
}
