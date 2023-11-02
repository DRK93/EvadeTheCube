using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyScripts
{
    public class HudManager : MonoBehaviour
    {
        public Text health;
        public Text Score;
        public void UpdateHealthText(float health)
        {
            this.health.text = "Health: " + health;
        }

        public void UpdateScore(float points)
        {
            this.Score.text = "Points: " + points;
        }
    }
}

