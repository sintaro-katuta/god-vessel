namespace GodVessel.Runtime
{
    public struct RuntimeStats
    {
        public int Attack;
        public int Defense;
        public float CritChance;
        public float CritMultiplier;

        public RuntimeStats(int attack, int defense, float critChance, float critMultiplier)
        {
            Attack = attack;
            Defense = defense;
            CritChance = critChance;
            CritMultiplier = critMultiplier;
        }
    }
}
