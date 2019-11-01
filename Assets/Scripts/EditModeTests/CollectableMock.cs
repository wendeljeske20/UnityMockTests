using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class CollectableMock
{
    [Test]
    public void PlayerDamageBuffCollect()
    {
        ICharacter player = new Player();
        player.damage = 5;

        DamageBuff damageBuff = new DamageBuff();
        damageBuff.amount = 10;

        damageBuff.SetCharacterStatus(player);

        Assert.AreEqual(15, player.damage);
    }

   


}
