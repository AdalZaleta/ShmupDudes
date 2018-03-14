using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool_Prefab : MonoBehaviour {

	void OnSpawn()
	{
		Invoke ("Suicide", 2);
	}

	void Suicide()
	{
		PoolManager.Despawn (gameObject);
	}
}
