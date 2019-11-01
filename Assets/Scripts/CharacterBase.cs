using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour, ICharacter
{
	public int moveSpeed { get; set; }

	public int damage { get; set; }

	public List<StatusEffectBase> statusEffects { get; set; }

	//Construtor
	public CharacterBase()
	{
		statusEffects = new List<StatusEffectBase>();
	}
}
