using GodVessel.Runtime;

namespace GodVessel.Combat
{
    public static class DamageCalculator
    {
        public static int CalculateFinalDamage(
            int basePower,
            float attackScale,
            float elementalBonus,
            bool isCritical,
            RuntimeStats attacker,
            RuntimeStats defender)
        {
            var critMultiplier = isCritical ? attacker.CritMultiplier : 1f;
            var scaledPower = (basePower + attacker.Attack) * attackScale;
            var elementalScaled = scaledPower * (1f + elementalBonus);
            var rawDamage = elementalScaled * critMultiplier;
            var reduced = rawDamage - defender.Defense;

            return reduced <= 1f ? 1 : (int)reduced;
        }
    }
}
