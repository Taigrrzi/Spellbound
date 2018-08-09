using System.Collections;
using System.Collections.Generic;
using SpellEffects;
using UnityEngine;

public class SEBlast : SpellEffect
{
    public void Update()
    {
        Collider2D[] results = new Collider2D[40];
        GetComponent<Collider2D>().OverlapCollider(new ContactFilter2D(), results);
        foreach (Collider2D collider in results)
        {
            if (collider.gameObject.tag == "gameEntity")
            {
                SpellController.main.CastSpell(mySpellNode.getContactSpell(), collider.GetComponent<GameEntity>(), gameObject);
            }
        }
        SpellController.main.CastSpell(mySpellNode.getTimeoutSpell(), null, gameObject);
        Destroy(gameObject);
    }
}
