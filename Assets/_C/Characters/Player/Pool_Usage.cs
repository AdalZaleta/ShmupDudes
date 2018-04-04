using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uniat.Pool
{
	public class Pool_Usage : MonoBehaviour {

		public GameObject prefab;
		public GameObject aim;
		bool canshoot = true;
		public int weapon = 1;
		float downTime;
		public int dmg;
		public Light lit;

		// Use this for initialization
		void Start () {
			for (int i = 0; i < 3; i++)
			{
				PoolManager.PreSpawn (prefab, 8);
				PoolManager.SetPoolLimit (prefab, 50);
				lit.enabled = false;
			}
		}
		
		// Update is called once per frame
		void Update () {

			switch (weapon)
			{
			case 0:
				dmg = 10;
				downTime = 0.0f;
				break;

			case 1:
				dmg = 20;
				downTime = 0.2f;
				break;

			case 2:
				dmg = 40;
				downTime = 0.05f;
				break;
			}

			if ((Input.GetAxis ("RightStick H") != 0) || (Input.GetAxis ("RightStick V") != 0) || (Input.GetKeyDown(KeyCode.Space))) 
			{
				if (canshoot) 
				{
					PoolManager.Spawn (prefab, aim.transform.position, Quaternion.identity);
					StartCoroutine (Spark ());
					StartCoroutine (Cooldown (downTime));
				}
			}

			if (Input.GetKeyDown(KeyCode.JoystickButton4))
			{
				if (weapon > 0)
					weapon--;
				else
					weapon = 2;
			}
			if (Input.GetKeyDown(KeyCode.JoystickButton5))
			{
				if (weapon < 2)
					weapon++;
				else
					weapon = 0;
			}
		}

		IEnumerator Cooldown(float downtime)
		{
			canshoot = false;
			yield return new WaitForSeconds (downtime);
			canshoot = true;
		}

		IEnumerator Spark()
		{
			lit.enabled = true;
			yield return new WaitForSeconds (0.02f);
			lit.enabled = false;
		}

	}
}