using UnityEngine;
using UnityEngine.InputSystem.Interactions;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public GameObject itemPrefab;
    public GameObject pickupPrefab;
}