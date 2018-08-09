using System;
using System.Collections;
using System.Collections.Generic;
using SpellInfo;
using SpellEffects;
using UnityEngine;

public class SCProjectile : MonoBehaviour,ISpellNode
{
    private Weapon weapon;
    private Sprite sprite;
	private float projectileSpeed;
    private ISpellEffect actualProjectile;
    private float timeout;

	public SCProjectile Init(String spritepath, float projectileSpeed, float timeout)
	{
		this.sprite = Resources.Load<Sprite>(spritepath);
		this.projectileSpeed = projectileSpeed;
		this.timeout = timeout;
		return this;
	}

	public void Cast()
	{
       // WorldController.main.CreateProjectile(Vector2 origin, Vector2 target, float lifeTime, ISpellEffect[] effects);
	}
}
