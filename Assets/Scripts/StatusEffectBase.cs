
public abstract class StatusEffectBase
{
    public float duration;
	public int amount;

	//Construtor
	public StatusEffectBase(int amount, int duration)
	{
		this.amount = amount;
		this.duration = duration;
	}

	public virtual void ApplyCharacterStatus(CharacterBase character)
    {
		character.statusEffects.Add(this);
	}

    public virtual void RemoveCharacterStatus(CharacterBase character)
    {
		character.statusEffects.Remove(this);
	}
}
