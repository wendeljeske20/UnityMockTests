using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
	public float health;
	public float healthRegen;
	public int damage;
	public int moveSpeed;
	
	public List<StatusEffectBase> statusEffects = new List<StatusEffectBase>();

	public void RegenHealth()
	{
		if (healthRegen != 0)
		{
			health += healthRegen * Time.deltaTime;
		}
	}
}
