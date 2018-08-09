using System.Collections;
using System.Collections.Generic;
using SpellEffects;
using UnityEngine;

public class SEProjectile : SpellEffect
{

    public float currentLifetime;
    public float trailTickTimer;

    private void Start()
    {
        currentLifetime = 0;
        trailTickTimer = 0;
    }

    private void Update()
    {
        currentLifetime += Time.deltaTime;
        trailTickTimer += Time.deltaTime;
        if (trailTickTimer > trailTickDelay) {
            SpellController.main.CastSpell(mySpellNode.getTrailSpell(), null, gameObject);
        }
        if (currentLifetime > timeoutTime)
        {
            SpellController.main.CastSpell(mySpellNode.getTimeoutSpell(), null, gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gameEntity")
        {
            SpellController.main.CastSpell(mySpellNode.getContactSpell(), collision.gameObject, gameObject);
        }
    }

}
