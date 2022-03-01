using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : Ability
{
	private float castingTime;
	private float castingTimeMultiplier;

	private float cooldown;
	private float cooldownMultiplier;

	public Spell(SpellSO spellSO)
	{
		damageType = spellSO.GetDamageType();
		flatDamage = spellSO.GetBaseDamage();
		damageMultiplier = 1f;

		flatAccuracy = spellSO.GetBaseAccuracy();
		accuracyMultiplier = 1f;

		isProjectile = spellSO.GetIsProjectile();

		flatAreaOfEffect = spellSO.GetBaseAreaOfEffect();
		areaOfEffectMultiplier = 1f;

		lastTimeCast = 0f;

		castingTime = spellSO.GetBaseCastingTime();
		castingTimeMultiplier = 1f;

		cooldown = spellSO.GetBaseCooldown();
		cooldownMultiplier = 1f;
	}

	public override bool CanCast()
	{
		return (Time.time - lastTimeCast) > (castingTime * castingTimeMultiplier) + (cooldown * cooldownMultiplier);
	}

	public override void Cast()
	{

	}
}
