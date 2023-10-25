using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float backgroundSpeed = 0.5f; // 배경 움직임 속도
    private float backgroundWidth; // 배경의 가로 길이

    private void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime); // 배경을 왼쪽으로 움직입니다.

        // 배경이 화면 왼쪽 끝을 넘어갔다면,
        if (transform.position.x <= -backgroundWidth)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 backgroundOffset = new Vector2(backgroundWidth * 2f, 0);
        transform.position = (Vector2)transform.position + backgroundOffset; // 배경을 오른쪽으로 다시 위치시킵니다.
    }
}
