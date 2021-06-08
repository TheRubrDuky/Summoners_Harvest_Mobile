using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Core
{
    [System.Serializable]
    public class SummonData
    {
        [SerializeField, Header("Genomes")]
        private Genome dominateGenome;
        [SerializeField]
        private Genome recessiveGenome;

        [SerializeField, Header("Affinity Types")]
        private Affinity primaryType;
        [SerializeField]
        private Affinity secondaryType;

        [SerializeField, Header("Summon Stats")]
        private string summonName;
        [SerializeField, Range(0.0f, 9999.0f)]
        private float health;
        [SerializeField, Range(0.0f, 999.0f)]
        private float lifeStat;
        [SerializeField, Range(0.0f, 999.0f)]
        private float powerStat;
        [SerializeField, Range(0.0f, 999.0f)]
        private float defenceStat;
        [SerializeField, Range(0.0f, 999.0f)]
        private float intelligenceStat;
        [SerializeField, Range(0.0f, 999.0f)]
        private float speedStat;
        [SerializeField, Range(0.0f, 999.0f)]
        private float accuracyStat;
        [SerializeField, Range(0.0f, 100.0f)]
        private float trustStat;
        [SerializeField, Range(0.0f, 9999.0f)]
        private float fameStat;

        public Genome DominateGenome { get { return dominateGenome; } private set { } }
        public Genome RecessiveGenome { get { return recessiveGenome; } private set { } }
        public Affinity PrimaryType { get { return primaryType; } private set { } }
        public Affinity SecondaryType { get { return secondaryType; } private set { } }

        public string SummonName { get { return summonName; } private set { } }
        public float Health { get { return health; } private set { } }
        public float LifeStat { get { return lifeStat; } private set { } }
        public float PowerStat { get { return powerStat; } private set { } }
        public float DefenceStat { get { return defenceStat; } private set { } }
        public float IntelligenceStat { get { return intelligenceStat; } private set { } }
        public float SpeedStat { get { return speedStat; } private set { } }
        public float AccuracyStat { get { return accuracyStat; } private set { } }
        public float TrustStat { get { return trustStat; } private set { } }
        public float FameStat { get { return fameStat; } private set { } }


        public SummonData()
        {
            dominateGenome = null;
            recessiveGenome = null;

            primaryType = null;
            secondaryType = null;

            summonName = string.Empty;
            health = 1000.0f;
            lifeStat = 100.0f;
            powerStat = 100.0f;
            defenceStat = 100.0f;
            intelligenceStat = 100.0f;
            accuracyStat = 100.0f;
            speedStat = 100.0f;
            trustStat = 0.0f;
            fameStat = 0.0f;
        }

        public SummonData(SummonData data)
        {
            dominateGenome = data.DominateGenome;
            recessiveGenome = data.RecessiveGenome;

            primaryType = data.PrimaryType;
            secondaryType = data.SecondaryType;

            summonName = data.SummonName;
            health = data.Health;
            lifeStat = data.LifeStat;
            powerStat = data.PowerStat;
            defenceStat = data.DefenceStat;
            intelligenceStat = data.IntelligenceStat;
            accuracyStat = data.AccuracyStat;
            speedStat = data.SpeedStat;
            trustStat = data.TrustStat;
            fameStat = data.FameStat;
        }
    }
}