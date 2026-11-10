using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Stats & Attributes")]
    [SerializeField] float atkRange;
    [SerializeField] int atkDmg;
    [SerializeField] float atkCooldown;



    [SerializeField] float speed = 4f;
    [SerializeField] Attack attack;

    Vector2 facingDirection;
    public static PlayerControls playerInstance;
    bool cooldown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerInstance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        facingDirection = context.action.ReadValue<Vector2>();

        rb.linearVelocity = speed * facingDirection;
    }

    // TODO: Link up player input with using the fairy item
    public void OnHeal(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        // Try to find a fairy item that is a child of the player
        // If found call the relevant function from FairyItem.cs
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if(!cooldown)
        {
            Vector3 pt = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 direction = (Vector2)pt - (Vector2)transform.position;
            float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
            Quaternion facingAngle = Quaternion.Euler(0, 0, angle);
            Attack a = Instantiate(attack, transform.position, facingAngle);
            a.SetDamage(atkDmg,gameObject);
            cooldown = true;
            Invoke("ResetCooldown", atkCooldown);
        }
    }


    void ResetCooldown()
    {
        cooldown=false;
    }
}
