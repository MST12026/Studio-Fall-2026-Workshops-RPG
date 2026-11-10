using UnityEngine;

public class FairyItem : MonoBehaviour
{
    [SerializeField] int healAmount = 20;
    [SerializeField] int usesLeft = 2;

    // TODO: Implement the heal functionality for the fairy item
    public void DoHeal()
    {
        // Add healAmount to player's health (hint: you may need to access the PlayerVals component for this!)
        // If there's more than one use left, decrement usesLeft
        // Otherwise, destroy the item
    }
}
