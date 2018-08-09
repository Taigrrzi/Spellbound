namespace SpellEffects
{
    public interface ISpellEffect
    {
        void onContact();
        void onSustainedContact();
        void onTimeout();
        void onTrail();
        void onCrossed();
    }
}
