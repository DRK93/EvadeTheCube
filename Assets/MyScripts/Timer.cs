using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyScripts
{
    public class Timer : MonoBehaviour
    {
        public float timer;

        public float timerTick;

        public float speedUp = 0f;
        // Start is called before the first frame update
        void Start()
        {
            timer = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > timerTick)
            {
                timer = 0f;
                if(speedUp < 15)
                    speedUp++;
            }
        }
    }
}

