using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegenBuff : StatusEffectBase
{
	public int amount;

	public HealthRegenBuff()
	{
		amount = 25;
		duration = 3;
	}

	public override void ApplyCharacterStatus(CharacterBase character)
	{
		base.ApplyCharacterStatus(character);
		character.healthRegen += amount;
	}

	public override void RemoveCharacterStatus(CharacterBase character)
	{
		base.RemoveCharacterStatus(character);
		character.healthRegen = 0;
	}
}
