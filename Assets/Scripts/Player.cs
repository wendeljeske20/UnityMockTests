using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: CharacterBase
{
	//Construtor
	public Player()
    {
		moveSpeed = 300;
        damage = 50;
		health = 100;
		healthRegen = 0;
    }

}
