using System.Collections.Generic;

public class SNProjectile : SpellNode
{
    private SpellNode contactSpell;
    private SpellNode trailSpell;



    public SNProjectile(SpellNode contactSpell, SpellNode timeoutSpell = null, float timeoutTime = 0, SpellNode trail = null) : base(timeoutSpell, timeoutTime)
    {
        
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
