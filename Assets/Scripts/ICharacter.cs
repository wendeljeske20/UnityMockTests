using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    int moveSpeed { get; set; }
    int damage { get; set; }

    List<StatusEffectBase> statusEffects { get; set; }
    

}
