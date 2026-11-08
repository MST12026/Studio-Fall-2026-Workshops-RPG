using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int playerHealth = 40;
    private const int maxHealth = 40;

    public void SetHealth(int health)
    {
        if (health > maxHealth)
            playerHealth = 40;
        else if (health < 0)
            playerHealth = 0;
        else
            playerHealth = health;
    }

    public int GetHealth => playerHealth;
}
