using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Core
{
    [System.Serializable]
    public struct StatAttunement
    {
        #region Private Variables

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Life Stat.")]
        private float lifeAttunement;

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Power Stat.")]
        private float powerAttunement;

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Defence Stat.")]
        private float defenceAttunement;

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Intelligence Stat.")]
        private float intelligenceAttunement;

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Speed Stat.")]
        private float speedAttunement;

        [SerializeField, Range(0.0f, 1.0f), Tooltip("How in tune this Genome is with the Accuracy Stat.")]
        private float accuracyAttunement;

        #endregion

        #region Public Variables

        public float LifeAttunemnt { get { return lifeAttunement; } private set { } }
        public float PowerAttunement { get { return powerAttunement; } private set { } }
        public float DefenceAttunement { get { return defenceAttunement; } private set { } }
        public float IntelligenceAttunement { get { return intelligenceAttunement; } private set { } }
        public float SpeedAttunement { get { return speedAttunement; } private set { } }
        public float AccuracyAttunement { get { return accuracyAttunement; } private set { } }

        #endregion

        public StatAttunement(float lifeAttunement, float powerAttunement, float defenceAttunement, float intelligenceAttunement, float speedAttunement, float accuracyAttunement)
        {
            this.lifeAttunement = lifeAttunement;
            this.powerAttunement = powerAttunement;
            this.defenceAttunement = defenceAttunement;
            this.intelligenceAttunement = intelligenceAttunement;
            this.speedAttunement = speedAttunement;
            this.accuracyAttunement = accuracyAttunement;
        }
    }

    [System.Serializable]
    public class Genome
    {
        [SerializeField]
        private string genomeName;
        [SerializeField]
        private GenomeType genomeType;
        [SerializeField]
        private StatAttunement statAttunement;

        public string GenomeName { get { return genomeName; } private set { genomeName = genomeType.ToString("G"); } }
        public GenomeType GenomeType { get { return genomeType; } private set { } }
        public StatAttunement StatAttunement { get { return statAttunement; } private set { } }

        public Genome()
        {
            this.genomeType = GenomeType.NONE;
            this.statAttunement = new StatAttunement(0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f);
        }

        public Genome(GenomeType genomeType, StatAttunement statAttunement)
        {
            this.genomeType = genomeType;
            this.statAttunement = statAttunement;
        }
    }
}