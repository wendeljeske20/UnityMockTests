using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    int health { get; set; }

    int damage { get; set; }

    void Collect(CollectableBase collectable);

}
