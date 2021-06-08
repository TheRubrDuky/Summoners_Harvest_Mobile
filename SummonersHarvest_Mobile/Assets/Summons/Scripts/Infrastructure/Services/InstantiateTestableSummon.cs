using RD.SummonersHarvestMobile.Summons.Core;
using UnityEngine;

namespace RD.SummonersHarvestMobile.Summons.Infrastructure
{
    public class InstantiateTestableSummon : MonoBehaviour
    {
        public GameObject TestingPrefab;

        void Start()
        {
            GameObject cube = Instantiate(TestingPrefab, Vector3.zero, Quaternion.identity);

            Summon testSummon = cube.AddComponent<Summon>() as Summon;

            testSummon.InitializeSummon();
        }
    }
}