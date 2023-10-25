using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // 점프 힘
    private bool isGrounded = true; // 캐릭터가 바닥에 있으면 true, 공중에 있으면 false
    private Rigidbody2D rb;
    private Quaternion startRotation;
    private Quaternion endRotation;
    private float rotationTime = 1f; // 회전에 걸리는 시간 (초)
    private float currentRotationTime = 0;
    private bool isRotating = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 화면 터치하고 바닥에 있을 때
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            Jump();
        }

        if (isRotating)
        {
            currentRotationTime += Time.deltaTime;
            float fraction = currentRotationTime / rotationTime;

            transform.rotation = Quaternion.Slerp(startRotation, endRotation, fraction);

            if (fraction >= 1)
            {
                isRotating = false;
            }
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(0, jumpForce);
        isGrounded = false;

        // 회전 시작을 위한 초기화
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - 90); // 오른쪽으로 180도 회전
        currentRotationTime = 0;
        isRotating = true;
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // 바닥 오브젝트와 충돌 감지
        {
            isGrounded = true;
        }
    }
}
