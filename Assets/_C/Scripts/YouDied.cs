using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ShmupDudes
{
	public class YouDied : MonoBehaviour {

		GameObject player;
		public Sprite[] hpList;
		public Sprite[] faceList;
		public Image face;
		public Image HPbar;
		public Image ded;
		public Text txtA;
		public Text txtB;
		bool isded = false;
		float alpha = 0;
		int hpspriteindex;

		// Use this for initialization
		void Start () {
			player = GameObject.FindGameObjectWithTag ("Player");
		}
		
		// Update is called once per frame
		void Update () {
			if (!player)
				if (!isded)
				{
					HPbar.sprite = hpList [0];
					StartCoroutine (death (0));
					isded = true;
				}

			if (player)
			{
				hpspriteindex = player.GetComponent<Character_Stats> ().currentHP;
				HPbar.sprite = hpList[hpspriteindex];

				if (hpspriteindex >= 10)
					face.sprite = faceList [0];
				if (hpspriteindex < 10 && hpspriteindex >= 5)
					face.sprite = faceList [1];
				if (hpspriteindex < 5)
					face.sprite = faceList [2];
			}

			if (Input.GetKeyDown (KeyCode.JoystickButton6) && Input.GetKeyDown (KeyCode.JoystickButton7)) {
				SceneManager.LoadScene ("UI_MainMenu");
			}

			if(Input.GetKeyDown(KeyCode.JoystickButton1) && isded)
			{
				SceneManager.LoadScene ("UI_MainMenu");
			}

			if (isded && Input.GetKeyDown(KeyCode.JoystickButton0) && !Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene (SceneManager.GetActiveScene().name);
			}
				
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene ("UI_MainMenu");
			}
		}

		IEnumerator death(float alph)
		{
			if (alpha < 1.000)
			{
				alpha+=0.03f;
				ded.color = new Color (1.000f, 1.000f, 1.000f, alpha);
				txtA.color = new Color (1.000f, 1.000f, 1.000f, alpha);
				txtB.color = new Color (1.000f, 1.000f, 1.000f, alpha);
				yield return new WaitForSeconds (0.02f);
				alph = alpha;
				StartCoroutine (death (alph));
			}
		}
	}
}
