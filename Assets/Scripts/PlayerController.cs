using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private ServiceHub serviceHub;

    public float moveSpeed;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    private bool moveEnabled = true;

    private bool isPaused = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        serviceHub = ServiceHub.Instance;
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

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isPaused = !isPaused;
            serviceHub.UIManager.TogglePause();

            if (isPaused) Time.timeScale = 0f;
            else Time.timeScale = 1f;
        }
    }
}
