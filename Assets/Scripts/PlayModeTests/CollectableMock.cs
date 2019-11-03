using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CollectableMock
{

	float timer;

	// A UnityTest behaves like a coroutine in Play Mode.
	[UnityTest]
	public IEnumerator TestHealthRegenUpdate()
	{
		GameObject playerGO = new GameObject("Player");
		Player player = playerGO.AddComponent<Player>();

		HealthRegenBuff healthRegenBuff = new HealthRegenBuff();

		healthRegenBuff.ApplyCharacterStatus(player);

		while (timer < healthRegenBuff.duration)
		{
			player.UpdateHealth();
			timer += UnityEngine.Time.deltaTime;
			yield return null;
		}

		Assert.GreaterOrEqual(player.health, 150);
	}

	//[UnityTest]
	//public IEnumerator NewTestScriptWithEnumeratorPasses2()
	//{

	//	while (timer < 5)
	//	{
	//		Debug.Log("2");
	//		timer += UnityEngine.Time.deltaTime;
	//		yield return null;
	//	}

	//	Assert.IsTrue(true);
	//}
}
