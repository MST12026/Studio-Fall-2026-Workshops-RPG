using UnityEngine;

public class DamageBoostItem : MonoBehaviour
{
    [SerializeField] float boostTime;

    // TODO: Implement damage boost
    void Start()
    {
        // Apply a damage boost to the player as soon as the item starts its lifetime
        // Consider using Invoke to time this event!
    }

    public void EndDamageBoost()
    {
        // Revoke the damage boost
        // Destroy the item
    }
}
