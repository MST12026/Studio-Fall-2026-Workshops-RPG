using Pathfinding;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    EntityData entityData_;
    AIPath pathfinder_;
    [SerializeField] Attack attack;
    [SerializeField] int atkDmg;
    [SerializeField] float atkCooldown;
    [SerializeField] float atkRange;

    Vector3 initialPos;
    bool cooldown;
    void Awake()
    {
        entityData_ = GetComponent<EntityData>();
        pathfinder_ = GetComponent<AIPath>();
        initialPos = transform.position;
        pathfinder_.endReachedDistance = atkRange;
    }

    private void Start()
    {
        AIDestinationSetter dest = GetComponent<AIDestinationSetter>();
        dest.target = PlayerControls.playerInstance.gameObject.transform;
    }
    public void resetPosition()
    {
        entityData_.SetHealth(int.MaxValue);
        transform.position = initialPos;
    }


    private void FixedUpdate()
    {
        if (pathfinder_.reachedEndOfPath)
        {
            if (!cooldown)
            {
                Vector3 pt = PlayerControls.playerInstance.gameObject.transform.position;
                Vector2 direction = (Vector2)pt - (Vector2)transform.position;
                float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
                Quaternion facingAngle = Quaternion.Euler(0, 0, angle);
                Attack a = Instantiate(attack, transform.position, facingAngle);
                a.SetDamage(atkDmg, gameObject);
                cooldown = true;
                Invoke("ResetCooldown", atkCooldown);
            }
        }
    }

    void ResetCooldown()
    {
        cooldown = false;
    }
}
