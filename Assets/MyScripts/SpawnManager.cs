using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyScripts
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public GameObject enemyPrefab2;
        public GameObject enemyPrefab3;
        public Vector2 spawnRangeX;
        void Start()
        {
            InvokeRepeating(nameof(SpawnEvader), 0, 1.0f);
            InvokeRepeating(nameof(SpawnCatcher), 1.0f, 2.0f);
            InvokeRepeating(nameof(SpawnSaver), 10.0f, 15.0f);
        }

        private void SpawnCatcher()
        {
            SpawnEnemy(EnemyType.Catcher);
        }

        private void SpawnEvader()
        {
            SpawnEnemy(EnemyType.Evader);
        }

        private void SpawnSaver()
        {
            SpawnEnemy(EnemyType.Saver);
        }
        private void SpawnEnemy(EnemyType enemyType)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(spawnRangeX[0], spawnRangeX[1]),
                enemyPrefab.transform.position.y,
                enemyPrefab.transform.position.z
            );

            if (enemyType == EnemyType.Evader)
            {
                Instantiate(
                    enemyPrefab,
                    spawnPosition,
                    enemyPrefab.transform.rotation
                );
            }
            else if(enemyType == EnemyType.Catcher)
            {
                Instantiate(
                    enemyPrefab2,
                    spawnPosition,
                    enemyPrefab2.transform.rotation
                );
            }
            else
            {
                Instantiate(
                    enemyPrefab3,
                    spawnPosition,
                    enemyPrefab3.transform.rotation
                );
            }
        }
    }
}

