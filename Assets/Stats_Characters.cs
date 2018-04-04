using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Info/Stats", order = 1)]
public class Stats_Characters : ScriptableObject {
	public string objectName = "New Sats";
	public float invensiblecd = 2;
	public int HP = 100;
	public int Damage = 3;
	public float speed = 5;
}
