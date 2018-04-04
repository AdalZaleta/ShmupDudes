using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ShmupDudes
{

	//TODO no necesita ser un manager como tal, es una instancia de un character (Bonus, el jugador, IA, etc pueden heredar de aqui)
	public class Instance_Character : MonoBehaviour
	{

		public Stats_Characters statsCharacter;

		//TODO crear una clase "CharacterStats" que maneja la vida, o cosas que van cambiando (puede pegar, estado de daño, etc)
		[SerializeField]
		private Transform myChild;
		[SerializeField]
		private Rigidbody myFather;

		void Awake()
		{
			Manager_Static.characterInstance = this;
			myFather = transform.GetComponentInParent<Rigidbody> ();
		}

		public void Movement(Vector2 _direction)
		{
			transform.Translate (new Vector3 (_direction.x, 0, _direction.y) * Time.deltaTime * statsCharacter.speed, Space.World);
		}

		public void MovementRigi(Vector2 _direction)
		{
			myFather.velocity = new Vector3(_direction.x, 0, _direction.y) * statsCharacter.speed;
		}

		public void Rotation(Vector3 _rotation)
		{
			transform.rotation = Quaternion.Euler (_rotation);
			Debug.Log(Quaternion.Euler (_rotation));
		}

		public void RotationChild(Vector3 _rotation)
		{
			myChild.rotation = Quaternion.Euler (_rotation);
		}
	}
}
