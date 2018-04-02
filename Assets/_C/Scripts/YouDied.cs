using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouDied : MonoBehaviour {

	GameObject player;
	public Image ded;
	bool isded = false;
	float alpha = 0;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (!player)
			if (!isded)
			{
				StartCoroutine (death (0));
				isded = true;
			}
	}

	IEnumerator death(float alph)
	{
		if (alpha < 1.000)
		{
			alpha+=0.03f;
			ded.color = new Color (1.000f, 1.000f, 1.000f, alpha);
			yield return new WaitForSeconds (0.02f);
			alph = alpha;
			StartCoroutine (death (alph));
		}
	}
}
