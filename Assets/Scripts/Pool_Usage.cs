using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uniat.Pool
{
	public class Pool_Usage : MonoBehaviour {

		public GameObject prefab;

		// Use this for initialization
		void Start () {
			PoolManager.PreSpawn (prefab, 8);
			PoolManager.SetPoolLimit (prefab, 20);
		}
		
		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown(KeyCode.Space))
				PoolManager.Spawn (prefab, transform.position, Quaternion.identity);
		}
	}
}