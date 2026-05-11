using GodVessel.Data;

namespace GodVessel.Fusion
{
    public static class FusionService
    {
        public static bool CanFuse(WeaponData baseWeapon, WeaponData materialWeapon, int currentFusionCount)
        {
            if (baseWeapon == null || materialWeapon == null)
            {
                return false;
            }

            if (currentFusionCount >= baseWeapon.maxFusionCount)
            {
                return false;
            }

            // Legendary result requires at least one legendary input.
            if (baseWeapon.rarity == WeaponRarity.Legendary || materialWeapon.rarity == WeaponRarity.Legendary)
            {
                return true;
            }

            return true;
        }

        public static WeaponRarity ResolveResultRarity(WeaponRarity baseRarity, WeaponRarity materialRarity)
        {
            var maxInput = baseRarity > materialRarity ? baseRarity : materialRarity;
            var increased = (int)maxInput + 1;

            if (increased > (int)WeaponRarity.Legendary)
            {
                increased = (int)WeaponRarity.Legendary;
            }

            return (WeaponRarity)increased;
        }
    }
}
