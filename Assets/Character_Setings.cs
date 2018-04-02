using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShmupDudes
{
	//Player controller (Si fuera una IA, seria un script similar a este, pero que en lugar de usar el input manager, usa su propia logica de IA para mover un character)
	public class Manager_Controller : MonoBehaviour 
	{
		//el character a controlar
		public Manager_Character myCharacter;

		//TODO si se quiere hacer multiplayer local, puedes agregar aqui, que Joystick va a utilizar
		public ControllerSide controllerSide;


		void Awake()
		{
			Manager_Static.controllerManager = this;
		}
		
		void Update () 
		{
			myCharacter.Movement (Manager_Static.inputManager.GetDirection(controllerSide));

		}
	}
}
