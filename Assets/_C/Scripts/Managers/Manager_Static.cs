﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShmupDudes
{
	public enum AppState
	{
		main_menu,
		gameplay,
		pause_menu,
		end_game
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
		public static Instance_Character characterInstance;
		public static Manager_Controller controllerManager;
		public static Manager_Audio audioManager;
		public static Manager_Scene sceneManager;
	}
}
