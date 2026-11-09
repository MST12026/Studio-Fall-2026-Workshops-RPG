using UnityEngine;


public class Door : MonoBehaviour
{
    [SerializeField] Room room;
    public Vector3 camTranslation;
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
            controller.minPos += camTranslation;
            controller.maxPos += camTranslation;
            collision.transform.position += playerTranslation;
            Debug.Log("entering " + room);
            room.RequestActiveRoom();
        }
    }
}
