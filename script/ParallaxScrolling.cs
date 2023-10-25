using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float backgroundSpeed = 0.5f; // ��� ������ �ӵ�
    private float backgroundWidth; // ����� ���� ����

    private void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime); // ����� �������� �����Դϴ�.

        // ����� ȭ�� ���� ���� �Ѿ�ٸ�,
        if (transform.position.x <= -backgroundWidth)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 backgroundOffset = new Vector2(backgroundWidth * 2f, 0);
        transform.position = (Vector2)transform.position + backgroundOffset; // ����� ���������� �ٽ� ��ġ��ŵ�ϴ�.
    }
}
