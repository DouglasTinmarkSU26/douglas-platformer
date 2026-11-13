using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

// what if I just blew everyone up with a nuke??? Wouldn't that be just so whacky?

public class Player : MonoBehaviour
{
    // bunny hopping variables just in case PGJDOSPG

    float bnyHopWindow = 0.5f;

    // end of buny hopningiangINAGSGFSGDAF


    Rigidbody2D rb;

    Vector2 moveInput;

    [SerializeField] float moveSpeed = 3.5f; 
    [SerializeField] float jumpForce = 20f;   

    [SerializeField] private ContactFilter2D groundFilter;
    bool isGrounded;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump()
    {
        Jump();
    }

    void FixedUpdate()
    {
        isGrounded = rb.IsTouching(groundFilter);
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, rb.linearVelocity.y);
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
