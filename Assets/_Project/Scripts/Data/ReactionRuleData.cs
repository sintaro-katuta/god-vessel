using UnityEngine;

namespace GodVessel.Data
{
    [CreateAssetMenu(fileName = "ReactionRule", menuName = "GodVessel/Data/Reaction Rule")]
    public class ReactionRuleData : ScriptableObject
    {
        public string reactionId;
        public string displayName;

        [Header("Trigger")]
        public ElementType primaryElement;
        public ElementType secondaryElement;

        [Header("Effect")]
        [Min(0f)] public float extraDamageMultiplier = 0.2f;
        [Min(0f)] public float crowdControlDuration = 0f;
    }
}
