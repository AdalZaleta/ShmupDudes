using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShmupDudes
{
	public class Manager_Input : MonoBehaviour {

		public Vector2 T_pos;
		public Vector3 R_pos;

		void Awake()
		{
			Manager_Static.inputManager = this;
		}

		void Update()
		{
			if (Manager_Static.appManager.currentState == AppState.gameplay) 
			{
				T_pos.Set (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
				if (Input.GetAxis ("RightStick V") != 0.0f || Input.GetAxis ("RightStick H") != 0.0f) 
				{
					R_pos.Set (0, Mathf.Atan2 (Input.GetAxis ("RightStick V"), Input.GetAxis ("RightStick H")) * Mathf.Rad2Deg, 0);

				}
			}
		}

		public Vector2 GetDirection(ControllerSide _side)
		{
			//TODO agregar mas controles
			return T_pos;
		}

		public Vector3 GetRotation(ControllerSide _side)
		{
			return R_pos;
		}
			
	}
}
