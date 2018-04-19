using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShmupDudes
{
	public class AnimatorDirection : MonoBehaviour {
		public float dirx;
		public float dirz;
		public int hpcoltroller;
		Animator anim;

		void Start()
		{
			anim = gameObject.GetComponent<Animator> ();
		}

		void Update()
		{
			hpcoltroller = gameObject.GetComponentInParent<Character_Stats> ().currentHP;
			if (Input.GetAxis ("RightStick H") > 0) {
				gameObject.GetComponent<SpriteRenderer> ().flipX = false;
				anim.SetBool ("Idle", false);
				anim.SetTrigger ("Walking");
			}
			if (Input.GetAxis ("RightStick H") < 0) {
				gameObject.GetComponent<SpriteRenderer> ().flipX = true;
				anim.SetBool ("Idle", false);
				anim.SetTrigger ("Walking");
			}
			if (Input.GetAxis ("RightStick H") != 0 && Input.GetAxis ("RightStick V") != 0 &&  Input.GetAxis ("Horizontal") != 0 &&  Input.GetAxis ("Vertical") != 0) {
				anim.SetBool ("Idle", true);
			}
			if (hpcoltroller <= 0) {
				anim.SetTrigger ("Death");
			}
		}

	}
}
