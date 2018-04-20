using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ShmupDudes
{
	public class UI_Manager : MonoBehaviour {
			
		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown (KeyCode.Escape))
				QuitGame ();
		}

		public void StartGame()
		{
			Manager_Static.audioManager.ApretarBoton (gameObject);
			SceneManager.LoadScene ("Enemy_test_A");
		}
		public void QuitGame()
		{
			Manager_Static.audioManager.ApretarBoton (gameObject);
			Application.Quit ();
		}

		public void Credits()
		{
			SceneManager.LoadScene ("Credits");
		}
	}
}
