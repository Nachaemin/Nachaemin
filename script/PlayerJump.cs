using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // ���� ��
    private bool isGrounded = true; // ĳ���Ͱ� �ٴڿ� ������ true, ���߿� ������ false
    private Rigidbody2D rb;
    private Quaternion startRotation;
    private Quaternion endRotation;
    private float rotationTime = 1f; // ȸ���� �ɸ��� �ð� (��)
    private float currentRotationTime = 0;
    private bool isRotating = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ȭ�� ��ġ�ϰ� �ٴڿ� ���� ��
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

        // ȸ�� ������ ���� �ʱ�ȭ
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - 90); // ���������� 180�� ȸ��
        currentRotationTime = 0;
        isRotating = true;
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // �ٴ� ������Ʈ�� �浹 ����
        {
            isGrounded = true;
        }
    }
}
