using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedDebuffStatus : StatusEffectBase
{
	public MoveSpeedDebuffStatus(int amount, int duration) : base(amount, duration)
	{
	}

	public override void ApplyCharacterStatus(CharacterBase character)
	{
		base.ApplyCharacterStatus(character);
		character.moveSpeed -= amount;
	}

	public override void RemoveCharacterStatus(CharacterBase character)
	{
		base.RemoveCharacterStatus(character);
		character.moveSpeed += amount;
	}
}
