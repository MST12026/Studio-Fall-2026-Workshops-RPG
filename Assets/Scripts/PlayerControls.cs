using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] float speed = 4f;
    [SerializeField] PlayerData playerData;

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

        rb.linearVelocity = speed * moveDir;
    }

    public void OnHeal(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        // Try to find a fairy item in the player's items list
        // If found call the DoHeal() function from FairyItem.cs
    }
}
