using System.Collections.Generic;
using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Core
{
    [System.Serializable]
    public abstract class Affinity : ScriptableObject
    {
        [SerializeField, Tooltip("Affinities that this Affinity is weak against.")]
        public List<Affinity> weakAgainst;

        [SerializeField, Tooltip("Affinities that this Affinity is strong against.")]
        public List<Affinity> strongAgainst;

        public float GetAffinityMultiplier(Affinity affinity)
        {
            float affinityMultiplier = 1.0f;

            for (int type = 0; type < weakAgainst.Count; type++)
            {
                if (weakAgainst[type] == affinity)
                    affinityMultiplier += 1.0f;
            }

            for (int type = 0; type < strongAgainst.Count; type++)
            {
                if (strongAgainst[type] == affinity)
                    affinityMultiplier -= 0.5f;
            }

            if (affinityMultiplier <= 0.0f)
                affinityMultiplier = 0.0f;

            return affinityMultiplier;
        }
    }
}