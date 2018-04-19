using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShmupDudes{
	public class Manager_Scene : MonoBehaviour {

		public int currentScene;

		public int killCount = 0;

		void Update()
		{
			if (killCount >= 5)
			{
				SceneManager.LoadScene ("WinScreen");
			}
		}

		void Awake()
		{
			Manager_Static.sceneManager = this;
			currentScene = SceneManager.GetActiveScene ().buildIndex;
			Debug.Log (currentScene);
			if (currentScene == 0) {
				gameObject.GetComponent<AudioSource>().clip  = Resources.Load ("Sounds/OST/op2") as AudioClip;
				gameObject.GetComponent<AudioSource> ().Play ();
			}
			if (currentScene == 1) {
				gameObject.GetComponent<AudioSource>().clip  = Resources.Load ("Sounds/OST/op3") as AudioClip;
				gameObject.GetComponent<AudioSource> ().Play ();
			}
		}
	}
}
