using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool_Prefab : MonoBehaviour {

	public float speed;

	void OnSpawn()
	{
		GetComponent<Rigidbody2D> ().AddRelativeForce (Vector2.up * speed * Time.deltaTime);
		Invoke ("Suicide", 2);
	}

	void Suicide()
	{
		PoolManager.Despawn (gameObject);
	}
}
