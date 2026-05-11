using UnityEngine;

namespace GodVessel.Data
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "GodVessel/Data/Weapon")]
    public class WeaponData : ScriptableObject
    {
        [Header("Identity")]
        public string weaponId;
        public string displayName;

        [Header("Core")]
        public WeaponRarity rarity = WeaponRarity.Common;
        public int baseAttack = 20;
        public ElementType element = ElementType.None;

        [Header("Fusion")]
        [Tooltip("Weapon fusion count cap. 0 means cannot be fused further.")]
        public int maxFusionCount = 3;

        [TextArea]
        public string passiveDescription;
    }
}
