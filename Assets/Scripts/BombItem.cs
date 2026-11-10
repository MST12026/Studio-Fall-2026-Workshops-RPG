using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float timeToExplode;
    [SerializeField] int numBombs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // TODO: Implement PlantBomb()
    public void PlantBomb()
    {
        // Instantiate a bomb game object
        // Let it explode after timeToExplode amount of time (consider using Invoke)
    }

    public void ExplodeBomb()
    {
        // Blow it up (get creative; you will probably have to create a script for your bomb gameobject!)
    }
}
