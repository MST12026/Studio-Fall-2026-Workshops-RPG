using UnityEngine;

public class BoomerangItem : MonoBehaviour
{
    [SerializeField] float airDistance;
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;  // Bonus task if you want to make your boomerang fancy :D
    private bool boomerangThrown = false;

    public void ThrowBoomerang()
    {
        // If boomerang isn't already in the air, throw it, and update its thrown state
        // This is a case where you will probably have to create a separate script for your boomerang gameobject!
    }
}
