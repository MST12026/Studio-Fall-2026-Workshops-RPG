using UnityEngine;

public class EntityData : MonoBehaviour
{
    [SerializeField] protected int health_ = 40;
    [SerializeField] protected const int maxHealth = 40;

    public virtual void SetHealth(int health)
    {
        if (health > maxHealth)
            health_ = maxHealth;
        else if (health < 0)
            health_ = 0;
        else
            health_ = health;
    }

    public virtual void TryDealDamage(int damage)
    {
        health_ -= damage;
        if (health_ <= 0)
        {
            HandleDeath();
        }
    }

    protected virtual void HandleDeath()
    {
        gameObject.SetActive(false);
    }


    public int GetHealth => health_;
}
