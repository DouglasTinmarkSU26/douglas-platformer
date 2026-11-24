using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FlipHorizontalmovement();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trigger"))
        {
            FlipHorizontalmovement();
        }
    }

    private void FlipHorizontalmovement()
    {
        moveSpeed = -moveSpeed;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}
