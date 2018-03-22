﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShmupDudes
{
	public enum AppState
	{
		main_menu,
		gameplay,
		pause_menu
	}

	public enum ControllerSide
	{
		player1 = 0,
		player2 = 1
	}

	public static class Manager_Static 
	{
		public static Manager_Input inputManager;
		public static Manager_App appManager;
		public static Manager_Character characterManager;
		public static Manager_Controller controllerManager;
	}
}
