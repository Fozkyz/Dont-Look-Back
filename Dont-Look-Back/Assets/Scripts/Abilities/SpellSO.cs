using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Ability/Spell")]
public class SpellSO : AbilitySO
{
	[SerializeField] float baseCastingTime;
	[SerializeField] float baseCooldown;

	public float GetBaseCastingTime()
	{
		return baseCastingTime;
	}

	public float GetBaseCooldown()
	{
		return baseCooldown;
	}
}
