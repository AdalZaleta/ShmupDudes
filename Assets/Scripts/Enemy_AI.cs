using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour {

	GameObject Player;
	NavMeshAgent agent;
	public int HP;
	public int dmg;

	void OnTriggerEnter (Collider _col)
	{
		if (_col.gameObject.CompareTag ("bullet"))
		{
			dmg = Player.gameObject.GetComponent<Uniat.Pool.Pool_Usage> ().dmg;
			StartCoroutine (Blink (dmg));
		}
	}

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
		agent.destination = Player.transform.position; 

		if (HP <= 0)
			Destroy (gameObject);
	}

	IEnumerator Blink(int damage)
	{
		HP -= damage;
		gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
		yield return new WaitForSeconds (0.02f);
		gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
