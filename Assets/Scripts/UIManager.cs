using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Sprite heartFull;
    [SerializeField] Sprite heartHalf;
    [SerializeField] Sprite heartEmpty;
    
    [SerializeField] Image[] hearts;

    public static UIManager instance_;
    private void Awake()
    {
        instance_ = this;
    }
    public void UpdateHealthDisplay(int health)
    {
        int remainingHealth = Mathf.Max(health, 0);
        for (int i = 0; i < hearts.Length; i++)
        {
            if (remainingHealth >= 2)
            {
                hearts[i].sprite = heartFull;
                remainingHealth -= 2;
            }
            else if (remainingHealth == 1)
            {
                hearts[i].sprite = heartHalf;
                remainingHealth = 0;
            }
            else
            {
                hearts[i].sprite = heartEmpty;
            }
        }
    }
}
