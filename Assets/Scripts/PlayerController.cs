using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public bool moveEnabled = true;
    private bool isPaused = false;

    private Interactable_Dialogue targetInteractable;
    [SerializeField] private GameObject debugCurrentInteractable;

    private UIManager uiManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        uiManager = ServiceHub.Instance.UIManager;
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
            uiManager.TogglePause();

            if (isPaused) Time.timeScale = 0f;
            else Time.timeScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Interactable_Dialogue foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = collision.gameObject;

            uiManager.ShowPrompt();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Interactable_Dialogue foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;

            uiManager.HidePrompt();
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if(context.performed && targetInteractable != null)
        {
            uiManager.HidePrompt();
            targetInteractable.Interact();
        }
    }
}
