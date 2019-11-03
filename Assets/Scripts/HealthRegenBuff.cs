
public class HealthRegenBuff : StatusEffectBase
{
	public HealthRegenBuff(int amount, int duration) : base(amount, duration)
	{
	}

	public override void ApplyCharacterStatus(CharacterBase character)
	{
		base.ApplyCharacterStatus(character);
		character.healthRegen += amount;
	}

	public override void RemoveCharacterStatus(CharacterBase character)
	{
		base.RemoveCharacterStatus(character);
		character.healthRegen -= amount;
	}
}
