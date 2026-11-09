using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : EntityData
{
    int mana_;

    void Start()
    {
        
    }

    protected override void HandleDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
