using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedDebuffStatus : StatusEffectBase
{
    public int amount = 100;
    public override void ApplyCharacterStatus(ICharacter character)
    {
        character.moveSpeed -= amount;
    }

    public override void RemoveCharacterStatus(ICharacter character)
    {
        character.moveSpeed += amount;
    }
}
