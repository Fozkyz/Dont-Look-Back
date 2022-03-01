using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability
{
	protected DamageType damageType;
	protected float flatDamage;
	protected float damageMultiplier;

	protected float flatAccuracy;
	protected float accuracyMultiplier;

	protected bool isProjectile;

	protected float flatAreaOfEffect;
	protected float areaOfEffectMultiplier;

	protected float lastTimeCast;

	public abstract bool CanCast();

	public abstract void Cast();
}
