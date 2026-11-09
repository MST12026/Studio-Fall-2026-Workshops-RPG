using UnityEngine;


public class Door : MonoBehaviour
{
    [SerializeField] Room room;
    public Vector3 playerTranslation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            collision.transform.position += playerTranslation;
            room.RequestActiveRoom();
        }
    }
}
