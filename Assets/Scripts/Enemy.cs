using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health_;

    Vector3 initialPos;
    void Awake()
    {
        initialPos = transform.position;
    }

    public void resetPosition()
    {
        transform.position = initialPos;
    }

}
