using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] float speed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveDir = context.action.ReadValue<Vector2>();
        Debug.Log(moveDir);

        rb.linearVelocity = speed * moveDir;
    }


}
