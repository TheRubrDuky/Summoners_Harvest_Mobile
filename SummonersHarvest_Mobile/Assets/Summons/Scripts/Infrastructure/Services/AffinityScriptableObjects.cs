using RD.SummonersHarvestMobile.Summons.Core;
using RD.SummonersHarvestMobile.Utilities.Core;
using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Infrastructure
{
    public class AffinityScriptableObjects : MonoBehaviourSingleton<AffinityScriptableObjects>
    {
        [SerializeField]
        public FireAffinity FireAffinity;

        [SerializeField]
        public WaterAffinity WaterAffinity;

        [SerializeField]
        public NormalAffinity NormalAffinity;

        [SerializeField]
        public EarthAffinity EarthAffinity;

        [SerializeField]
        public IceAffinity IceAffinity;

        [SerializeField]
        public LightningAffinity LightningAffinity;

        [SerializeField]
        public ThunderAffinity ThunderAffinity;

        [SerializeField]
        public PoisonAffinity PoisonAffinity;

        [SerializeField]
        public WindAffinity WindAffinity;

        [SerializeField]
        public PsychicAffinity PsychicAffinity;
    }
}