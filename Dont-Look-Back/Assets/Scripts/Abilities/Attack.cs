using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Ability
{
	private float attackSpeed;
	private float attackSpeedMultiplier;

	public Attack (AttackSO attackSO)
	{
		damageType = attackSO.GetDamageType();
		flatDamage = attackSO.GetBaseDamage();
		damageMultiplier = 1f;

		flatAccuracy = attackSO.GetBaseAccuracy();
		accuracyMultiplier = 1f;

		isProjectile = attackSO.GetIsProjectile();

		flatAreaOfEffect = attackSO.GetBaseAreaOfEffect();
		areaOfEffectMultiplier = 1f;

		lastTimeCast = 0f;

		attackSpeed = attackSO.GetBaseAttackSpeed();
		attackSpeedMultiplier = 1f;
	}

	public override bool CanCast()
	{
		return (Time.time - lastTimeCast) < 1 / (attackSpeed * attackSpeedMultiplier);
	}

	public override void Cast()
	{

	}
}
