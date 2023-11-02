using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyScripts
{
    public enum EnemyType
    {
        Catcher,
        Evader,
        Saver
    }
    public class EnemyController : MonoBehaviour
    {
        public float speed;
        public EnemyType enemyType;
        private float m_TresholdPositionZ =-20.0f;
        private PlayerController m_Pc;
        private void Start()
        {
            m_Pc = GameObject.Find("Player").GetComponent<PlayerController>();
            RandomizeSpeed();
        }
        private void Update()
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z - speed * Time.deltaTime);

            if (Vector3.Distance(m_Pc.transform.position, transform.position) < 1.0f)
            {
                if(enemyType == EnemyType.Evader)
                {
                    m_Pc.ReceiveDamage();
                }

                if (enemyType == EnemyType.Catcher)
                {
                    m_Pc.ReceivePoints();
                }

                if (enemyType == EnemyType.Saver)
                {
                    m_Pc.ReceiveHealth();
                }
                Destroy(gameObject);
            }
            else if (m_Pc.transform.position.z - transform.position.z > 5.0f && enemyType == EnemyType.Catcher)
            {
                m_Pc.ReceiveDamage();
                Destroy(gameObject);
            }
            else if(transform.position.z <= m_TresholdPositionZ)
            { 
                Destroy(gameObject);
            }
        }

        private void RandomizeSpeed()
        {
            speed = speed * Random.Range(1f, 2.5f);
        }
    }
}



