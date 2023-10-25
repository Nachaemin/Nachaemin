using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float leftBound = -15f; // 화면 왼쪽 경계 (이 값을 조정하여 장애물이 어디서 파괴될지 정할 수 있습니다)

    void Update()
    {
        // 장애물의 x 위치가 leftBound보다 작아지면 장애물을 파괴
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
