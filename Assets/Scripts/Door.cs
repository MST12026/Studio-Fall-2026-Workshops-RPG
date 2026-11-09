using UnityEngine;


public class Door : MonoBehaviour
{
    [SerializeField] Room room;
    public Vector3 playerTranslation;

    //    [SerializeField] private RoomManager room;
    private CameraController controller;

    private void Awake()
    {
        controller = Camera.main.GetComponent<CameraController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            collision.transform.position += playerTranslation;
            Debug.Log("entering " + room);
            room.RequestActiveRoom();
        }
    }
}
