using System.Collections.Generic;

namespace SpellInfo
{
    public interface ISpellNode
    {
        ISpellNode getTimeoutSpell();

        List<ISpellNode> getAllChildren();
    }
}