using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectBase
{
    public float duration;
    public virtual void ApplyCharacterStatus(ICharacter character)
    {
		character.statusEffects.Add(this);
	}

    public virtual void RemoveCharacterStatus(ICharacter character)
    {
		character.statusEffects.Remove(this);
	}
}
