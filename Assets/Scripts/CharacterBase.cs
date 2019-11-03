using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
	public int moveSpeed { get; set; }

	public float healthRegen { get; set; }
	public float health { get; set; }

	public int damage { get; set; }

	public List<StatusEffectBase> statusEffects { get; set; }

	//Construtor
	public CharacterBase()
	{
		statusEffects = new List<StatusEffectBase>();		
	}
}
