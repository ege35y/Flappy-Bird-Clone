using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float moveSpeed = 2f;

    private void Update()
    {
        rb2D.linearVelocityX = -moveSpeed;
    }
}
