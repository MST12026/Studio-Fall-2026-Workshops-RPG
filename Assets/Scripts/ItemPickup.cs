using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(itemSO.itemPrefab, other.gameObject.transform);
            Debug.Log("Picked up item!");
            Destroy(gameObject);
        }
    }
}
