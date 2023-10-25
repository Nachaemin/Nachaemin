using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float leftBound = -15f; // ȭ�� ���� ��� (�� ���� �����Ͽ� ��ֹ��� ��� �ı����� ���� �� �ֽ��ϴ�)

    void Update()
    {
        // ��ֹ��� x ��ġ�� leftBound���� �۾����� ��ֹ��� �ı�
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
