using System.Collections.Generic;
using UnityEngine;

public class SNProjectile : SpellNode
{
    float projSpeed;
    float projSize;
    UnityEngine.Sprite projSprite;

    SpellNode contactSpell;

    SpellNode trailSpell;
    float trailDelay;

    public SNProjectile(float projSpeed, float projSize, Sprite projSprite,
        SpellNode timeoutSpell = null, float timeoutTime = 0,
        SpellNode contactSpell = null, 
        SpellNode trailSpell = null, float trailDelay = 0) : base(timeoutSpell,timeoutTime)
    {
        this.projSpeed = projSpeed;
        this.projSize = projSize;
        this.projSprite = projSprite;
        this.contactSpell = contactSpell;
        this.trailSpell = trailSpell;
        this.trailDelay = trailDelay;
    }
    
    

    public override List<SpellNode> getSpecialChildren()
    {
        List<SpellNode> children = new List<SpellNode>();

        if(contactSpell != null)
        {
            children.Add(contactSpell);
        }
        if(trailSpell != null)
        {
            children.Add(trailSpell);
        }
        return children;
    }
}
