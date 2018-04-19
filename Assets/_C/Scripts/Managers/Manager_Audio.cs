using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShmupDudes
{
	public class Manager_Audio : MonoBehaviour {

		void Awake()
		{
			Manager_Static.audioManager = this;
			Debug.Log ("Hola");
			Debug.Log ("aaaa", gameObject);
		}

		void OnDestroy()
		{
			Debug.Log ("Algo me matooooo");
		}

		public void Disparo1(GameObject _gameobj)
		{
			_gameobj.GetComponent<AudioSource> ().PlayOneShot (Resources.Load ("Sounds/FBX/shoot3") as AudioClip);
		}

		public void ResporducirBGMusic(int _num)
		{
			if (_num == 2) {
				gameObject.GetComponent<AudioSource>().PlayOneShot(Resources.Load ("Sounds/OST/op3") as AudioClip);
			}
		}

		public void ApretarBoton(GameObject __gameobj)
		{
			__gameobj.GetComponent<AudioSource>().PlayOneShot(Resources.Load("Sounds/FBX/Menu/Menu selection") as AudioClip);
		}
	}
}
