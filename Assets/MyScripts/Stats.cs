using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyScripts
{
    public class Stats : MonoBehaviour
    {
        public float health;
        public float points;

        public void UpdateHealth (float value)
        {
            health -= value;
        }

        public void UpdatePoints(float value)
        {
            points += value;
        }
    }
}

