using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    private bool moveEnabled = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void HandlePlayerMovement()
    {
        if (!moveEnabled) return;

        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        HandlePlayerMovement();
    }
}
