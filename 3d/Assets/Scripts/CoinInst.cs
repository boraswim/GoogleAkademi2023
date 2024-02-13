using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CoinRand
{
public class CoinInst : MonoBehaviour
{
        public List<Transform> spawnPoints = new List<Transform>();
        [SerializeField] private GameObject coin;
        public HashSet<int> randomValues = new HashSet<int>();
        public System.Random r = new System.Random();

        void Start()
        {
            int a = (int)Math.Ceiling(spawnPoints.Count / 2.0f);
            
            while(randomValues.Count < a)
                {
                    randomValues.Add(r.Next(0,spawnPoints.Count() - 1));
                }
            foreach(var x in randomValues)
                {
                    Instantiate(coin, spawnPoints[x]);
                }
        }
}
}
