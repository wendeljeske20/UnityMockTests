using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeMock
{
	[UnityTest]
	public IEnumerator RegenPlayerHealth()
	{
		float timer = 0;

		//Inicializa
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>(); // health = 100
		HealthRegenBuffStatus healthRegenBuff = new HealthRegenBuffStatus(amount: 25, duration: 3);

		healthRegenBuff.ApplyCharacterStatus(player);

		//Teste
		Assert.AreEqual(25, player.healthRegen);
		Assert.Contains(healthRegenBuff, player.statusEffects);

		//Regenera a vida
		while (timer < healthRegenBuff.duration)
		{
			player.RegenHealth();
			timer += UnityEngine.Time.deltaTime;
			yield return null;
		}

		healthRegenBuff.RemoveCharacterStatus(player);

		//Teste
		Assert.AreEqual(0, player.healthRegen);
		Assert.False(player.statusEffects.Contains(healthRegenBuff));
		Assert.Greater(player.health, 150);
	}
}
