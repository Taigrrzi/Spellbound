using System.Collections.Generic;

public abstract class SpellNode
{
    SpellNode timeoutSpell;
    float timeoutTime;

    public SpellNode getTimeoutSpell()
    {
        return timeoutSpell;
    }

    protected SpellNode(SpellNode timeoutSpell, float timeoutTime)
    {
        this.timeoutSpell = timeoutSpell;
        this.timeoutTime = timeoutTime;
    }

    public abstract List<SpellNode> getSpecialChildren();
}
