﻿using System.Collections;
using System.Collections.Generic;
using SpellEffects;
using UnityEngine;

public class SpellController : MonoBehaviour{

    public static SpellController main;

	// Use this for initialization
	void Awake () {
        main = this;
	}

    /*public ISpellCast CreateFromCode(GameObject weapon,ISpellCode code) {
        switch (code.getID())
        {
            case "SPELLProjectile":
               // return weapon.AddComponent<SPELLProjectile>().SpellProjectileInit("Projectiles/bullet", 10f, 10f);
            case "SPELLConsoleBanger":
                return new SPELLConsoleBanger();
            default:
                return new SPELLConsoleBanger();
        }
    }*/

    public void CastSpell(SpellNode spellNode, GameEntity target, GameObject caster) {
        switch (spellNode.GetType().ToString())
        {
            case "SNProjectile":
                break;
            default:
                break;
        }
    }

    public void CreateProjectile(Vector2 origin, Vector2 target, float lifeTime, ISpellEffect[] effects, Sprite sprite, float projectileSpeed)
    {
        GameObject proj = Instantiate<GameObject>(Resources.Load<GameObject>("Projectiles/PProjectile"), gameObject.transform);
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        proj.GetComponent<SpriteRenderer>().sprite = sprite;
        proj.GetComponent<Rigidbody2D>().velocity = projectileSpeed * direction.normalized;
        proj.transform.Rotate(0, 0, Vector2.SignedAngle(Vector2.right, direction));

        Destroy(proj, lifeTime);
    }
}
