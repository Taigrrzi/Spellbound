using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellEffects;

public class SEBlast : MonoBehaviour,ISpellEffect {

    public float duration;
    public SpellNode mySpellNode;
    public float timeOutTimer;

    private void Update()
    {
        Collider2D[] results = new Collider2D[40];
        GetComponent<Collider2D>().OverlapCollider(new ContactFilter2D(),results);
        foreach (Collider2D collider in results)
        {
            if (collider.gameObject.tag == "gameEntity") {
                WorldController.main.ApplySpell(mySpellNode.getContactSpell(),collider.getComponent<GameEntity>());
            }
        }
        Destroy(this.gameObject);
    }
}
