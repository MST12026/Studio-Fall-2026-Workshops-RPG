using UnityEngine;
using UnityEngine.Animations;

public class FairyItem : MonoBehaviour
{
    [SerializeField] int healAmount = 20;
    [SerializeField] int usesLeft = 2;

    void Start()
    {
        
    }

    // TODO: Implement the heal functionality for the fairy item
    public void DoHeal()
    {
        // Add healAmount to player's health (hint: you may need to access the EntityData component for this!)
        // Update usesLeft
        // If no uses left, destroy the item
    }
}
