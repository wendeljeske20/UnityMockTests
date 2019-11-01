using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : CollectableBase
{
    public int amount = 10;
    public override void SetCharacterStatus(ICharacter character)
    {
        character.damage += amount;
    }

}
