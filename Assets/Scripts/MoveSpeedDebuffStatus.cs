using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedDebuffStatus : StatusEffectBase
{
    public int amount = 100;
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
