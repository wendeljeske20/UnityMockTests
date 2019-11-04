using UnityEngine;
using NUnit.Framework;

public class EditModeMock
{
	[Test]
	public void PlayerApplyDamageBuff()
	{
		//Inicializa
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>(); //damage = 50
		DamageBuffStatus damageBuff = new DamageBuffStatus(amount: 10, duration: 3);

		damageBuff.ApplyCharacterStatus(player);

		//Teste
		Assert.AreEqual(60, player.damage);
	}

	[Test]
	public void PlayerApplyMoveSpeedDebuff()
	{
		//Inicializa
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>(); // moveSpeed = 300
		MoveSpeedDebuffStatus moveSpeedDebuff = new MoveSpeedDebuffStatus(amount: 100, duration: 3);

		moveSpeedDebuff.ApplyCharacterStatus(player);

		//Teste
		Assert.Contains(moveSpeedDebuff, player.statusEffects);
	}
}
