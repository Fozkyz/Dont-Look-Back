using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack", menuName = "Ability/Attack")]
public class AttackSO : AbilitySO
{
	[SerializeField] private float baseAttackSpeed;

	public float GetBaseAttackSpeed()
	{
		return baseAttackSpeed;
	}
}
