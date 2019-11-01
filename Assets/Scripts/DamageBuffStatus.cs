using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuffStatus : StatusEffectBase
{
    public int amount = 10;
    public override void ApplyCharacterStatus(ICharacter character)
    {
		base.ApplyCharacterStatus(character);
        character.damage += amount;
    }

    public override void RemoveCharacterStatus(ICharacter character)
    {
		base.RemoveCharacterStatus(character);
		character.damage -= amount;
    }

}
