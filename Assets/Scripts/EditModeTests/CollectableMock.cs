using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class CollectableMock
{

	[Test]
	public void PlayerApplyDamageBuff()
	{
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>();

		DamageBuffStatus damageBuff = new DamageBuffStatus();

		damageBuff.ApplyCharacterStatus(player);
		//damageBuff.RemoveCharacterStatus(player);

		Assert.Contains(damageBuff, player.statusEffects);
	}

	[Test]
	public void PlayerApplyMoveSpeedDebuff()
	{
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>();

		MoveSpeedDebuffStatus moveSpeedDebuff = new MoveSpeedDebuffStatus();

		moveSpeedDebuff.ApplyCharacterStatus(player);

		Assert.AreEqual(200, player.moveSpeed);
	}




}
