using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public InputActionReference moveAction;
    private Vector2 moveInput;

    private void OnEnable()
    {moveAction.action.Enable();}
    void Update()
    {
        moveInput = moveAction.action.ReadValue<Vector2>();

        if (moveInput.x > 0f)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (moveInput.x < 0f)
            transform.localScale = new Vector3(-1f, 1f, 1f);

        rb.linearVelocity = moveInput * speed;
    }
    void Start()
    {       
     }
}
