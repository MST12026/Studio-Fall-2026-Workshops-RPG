using UnityEngine;

public class EntityData : MonoBehaviour
{
    [SerializeField] int health_ = 40;
    private const int maxHealth = 40;

    public void SetHealth(int health)
    {
        if (health > maxHealth)
            health_ = 40;
        else if (health < 0)
            health_ = 0;
        else
            health_ = health;
    }

    public void TryDealDamage(int damage)
    {
        health_ -= damage;
        if (health_ <= 0)
        {
            HandleDeath();
        }
    }

    protected virtual void HandleDeath()
    {
        Destroy(gameObject);
    }


    public int GetHealth => health_;
}
