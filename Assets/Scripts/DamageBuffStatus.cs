
public class DamageBuffStatus : StatusEffectBase
{
	public DamageBuffStatus(int amount, int duration) : base(amount, duration)
	{
	}

	public override void ApplyCharacterStatus(CharacterBase character)
    {
		base.ApplyCharacterStatus(character);
        character.damage += amount;
    }

    public override void RemoveCharacterStatus(CharacterBase character)
    {
		base.RemoveCharacterStatus(character);
		character.damage -= amount;
    }

}
