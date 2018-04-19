using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShmupDudes
{
	public class Character_Stats : MonoBehaviour {

		public Stats_Characters statsCharacter;
		public Animator anim;

		public int currentHP;
		public float currentSpeed;
		public bool invensible;

		void Update()
		{
			if (currentHP <= 0)
				Destroy (gameObject);
		}

		void Awake()
		{
			currentHP = statsCharacter.HP;
			currentSpeed = statsCharacter.speed;
		}

		void OnCollisionStay (Collision _col)
		{
			if (_col.gameObject.CompareTag ("Enemy")) {
				if (!invensible) {
					//Debug.Log ("El enemigo me sigue tocando :3");
					StartCoroutine (TakeDamageCourrutine (statsCharacter.invensiblecd, _col.gameObject.GetComponent<Character_Stats>().statsCharacter.Damage));
				}
			}
		}

		void TakeDamage(int _damage)
		{
			currentHP -= _damage;
			anim.SetTrigger ("Damage");
			if (currentHP <= 0) {
				Destroy (gameObject);
			}
		}

		IEnumerator TakeDamageCourrutine(float _cd, int _damage)
		{
			invensible = true;
			TakeDamage (_damage);
			transform.GetComponentInChildren<SpriteRenderer> ().material.color = Color.red;
			yield return new WaitForSeconds (0.1f);
			transform.GetComponentInChildren<SpriteRenderer> ().material.color = Color.white;
			yield return new WaitForSeconds (0.1f);
			transform.GetComponentInChildren<SpriteRenderer> ().material.color = Color.red;
			yield return new WaitForSeconds (0.1f);
			transform.GetComponentInChildren<SpriteRenderer> ().material.color = Color.white;
			yield return new WaitForSeconds (_cd - 0.3f);
			invensible = false;
		}
	}
}
