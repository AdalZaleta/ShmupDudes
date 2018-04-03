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
	float enemy_offset;
	public Animator anim;	

	void OnTriggerEnter (Collider _col)
	{
		if (_col.gameObject.CompareTag ("bullet"))
		{
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
		{
			agent.destination = Player.transform.position; 
			enemy_offset = Player.transform.position.x - transform.position.x;
		}else
		{
			agent.destination = transform.position;
			enemy_offset = 0;
		}

		if (enemy_offset <= 0)
			Slime.GetComponent<SpriteRenderer> ().flipX = false;
		else
			Slime.GetComponent<SpriteRenderer> ().flipX = true;

		if ((enemy_offset > -0.6f) && (enemy_offset < 0.6f))
		{
			anim.SetTrigger ("Attack");
		}else
		{
			anim.SetTrigger ("Walk");
		}
			
		if (HP <= 0)
		{
			anim.SetTrigger ("Dead");
			Destroy (gameObject, 1.2f);
		}
			
	}

	IEnumerator Blink(int damage)
	{
		HP -= damage;
		Slime.GetComponent<SpriteRenderer> ().color = Color.red;
		yield return new WaitForSeconds (0.02f);
		Slime.GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
