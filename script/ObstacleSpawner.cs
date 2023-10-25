using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // ��ֹ� Prefab
    public float spawnInterval = 2f; // ��ֹ��� �����Ǵ� ���� (��)

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
        float spawnYPosition = transform.position.y; // ��ֹ��� ������ Y ��ǥ
        Vector2 spawnPosition = new Vector2(transform.position.x, spawnYPosition);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
