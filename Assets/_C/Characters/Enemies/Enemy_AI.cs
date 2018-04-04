using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour {

	GameObject Player;
	NavMeshAgent agent;
	GameObject Slime;
	public int HP;
	public int dmg;
	public float enemy_offset;
	public Animator anim;
	bool located = false;

	void OnTriggerEnter (Collider _col)
	{
		if ((_col.gameObject.CompareTag ("bullet")) && HP > 0 )
		{
			if (!located)
				located = true;
			
			anim.SetTrigger ("Hit");
			dmg = Player.gameObject.GetComponent<Uniat.Pool.Pool_Usage> ().dmg;
			StartCoroutine (Blink (dmg));
		}
	}

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		Slime = GameObject.Find ("Slime");
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
		if (Player)
			enemy_offset = Player.transform.position.x - transform.position.x;

		if ((enemy_offset < 5) && (enemy_offset > -5))
			if (!located)
				located = true;

		if (Player && located)
		{
			agent.destination = Player.transform.position; 
			anim.SetTrigger ("Walk");
		}else
		{
			agent.destination = transform.position;
			anim.SetTrigger ("Idle");
		}

		if (enemy_offset <= 0)
			Slime.GetComponent<SpriteRenderer> ().flipX = false;
		else
			Slime.GetComponent<SpriteRenderer> ().flipX = true;

		if ((enemy_offset > -0.6f) && (enemy_offset < 0.6f))
		{
			anim.SetTrigger ("Attack");
		}

		if (HP <= 0)
		{
			agent.destination = transform.position;
			anim.SetTrigger ("Dead");
			Destroy (gameObject, 0.7f);
		}
			
	}

	IEnumerator Blink(int damage)
	{
		HP -= damage;
		Slime.GetComponent<SpriteRenderer> ().material.color = Color.red;
		yield return new WaitForSeconds (0.1f);
		Slime.GetComponent<SpriteRenderer> ().material.color = Color.white;
	}
}
