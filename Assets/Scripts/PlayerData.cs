using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : EntityData
{


    int mana_;

    void Start()
    {
        
    }

    public override void SetHealth(int health)
    {
        base.SetHealth(health);
        UIManager.instance_.UpdateHealthDisplay(health_);
    }

    protected override void HandleDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
