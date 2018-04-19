using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credit_Scroll : MonoBehaviour {

	public GameObject cred;
	public float vel;
	public Camera cam;

	// Use this for initialization
	void Start () {
		StartCoroutine (BackToMenu ());
	}
	
	// Update is called once per frame
	void Update () {
		cred.transform.Translate (Vector3.up * vel);
		cam.transform.Rotate (Vector3.up * vel / 5);
	}

	IEnumerator BackToMenu()
	{
		yield return new WaitForSeconds (30.0f);
		SceneManager.LoadScene ("UI_MainMenu");
	}
}
