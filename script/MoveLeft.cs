using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}