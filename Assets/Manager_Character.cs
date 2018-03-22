using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ShmupDudes
{
	//TODO no necesita ser un manager como tal, es una instancia de un character (Bonus, el jugador, IA, etc pueden heredar de aqui)
	public class Manager_Character : MonoBehaviour
	{
		//TODO meter estos settings en un Scriptable Object
		public float speed = 10;

		//TODO crear una clase "CharacterStats" que maneja la vida, o cosas que van cambiando (puede pegar, estado de daño, etc)
		private float currentLife;

		void Awake()
		{
			Manager_Static.characterManager = this;
		}

		public void Movement(Vector2 _direction)
		{
			transform.Translate (new Vector3 (_direction.x, 0, _direction.y) * Time.deltaTime * speed);
		}
	}
}
