using RD.SummonersHarvestMobile.Summons.Core;
using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Infrastructure
{
    public class Summon : MonoBehaviour
    {
        [SerializeField]
        protected SummonData summonData;

        protected float currenthealth;

        public void InitializeSummon()
        {
            if (summonData == null)
                summonData = new SummonData();

            currenthealth = summonData.Health;
        }

        public void InitializeSummon(SummonData data)
        {
            if (summonData == null)
                summonData = new SummonData(data);
            else
                summonData = data;

            currenthealth = summonData.Health;
        }

    }
}