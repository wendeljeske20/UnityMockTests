using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public int health { get; set; }

    public int damage { get; set; }

    public virtual void Collect(CollectableBase collectable)
    {

    }
}
