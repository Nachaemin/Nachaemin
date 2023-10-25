using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // 장애물 Prefab
    public float spawnInterval = 2f; // 장애물이 생성되는 간격 (초)

    private float nextSpawnTime = 0;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObstacle()
    {
        float spawnYPosition = transform.position.y; // 장애물이 생성될 Y 좌표
        Vector2 spawnPosition = new Vector2(transform.position.x, spawnYPosition);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
