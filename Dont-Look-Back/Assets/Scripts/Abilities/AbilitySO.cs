using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType { Physical, Elemental, Chaos, True }

public abstract class AbilitySO : ScriptableObject
{
	[SerializeField] private DamageType damageType;
	[SerializeField] private float baseDamage;
	[SerializeField] private float baseAccuracy;
	[SerializeField] private bool isProjectile;
	[SerializeField] private float baseAreaOfEffect;

	public DamageType GetDamageType()
	{
		return damageType;
	}

	public float GetBaseDamage()
	{
		return baseDamage;
	}

	public float GetBaseAccuracy()
	{
		return baseAccuracy;
	}

	public bool GetIsProjectile()
	{
		return isProjectile;
	}

	public float GetBaseAreaOfEffect()
	{
		return baseAreaOfEffect;
	}
}
