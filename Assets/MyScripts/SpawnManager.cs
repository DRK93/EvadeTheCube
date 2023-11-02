using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyScripts
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public GameObject enemy2Prefab;
        public Vector2 spawnRangeX;
        void Start()
        {
            InvokeRepeating(nameof(SpawnEvader), 0, 2.0f);
            InvokeRepeating(nameof(SpawnCatcher), 1.0f, 2.0f);
        }

        private void SpawnCatcher()
        {
            SpawnEnemy(EnemyType.Catcher);
        }

        private void SpawnEvader()
        {
            SpawnEnemy(EnemyType.Evader);
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
            else
            {
                Instantiate(
                    enemy2Prefab,
                    spawnPosition,
                    enemy2Prefab.transform.rotation
                );
            }
        }
    }
}

