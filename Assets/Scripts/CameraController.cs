using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    public float smoothSpeed;

    private Vector3 targetPos, newPos;

    public Vector3 minPos, maxPos;

    public static CameraController instance_;

    private void Start()
    {
        instance_ = this;
    }

    public void FocusRoom(Bounds b)
    {
        minPos = b.center;
        maxPos = b.center;
        minPos.z = -1;
        maxPos.z = -1;
    }

    public void FocusRoomFast(Bounds b)
    {
        minPos = b.center;
        maxPos = b.center;
        minPos.z = -1;
        maxPos.z = -1; 
        Vector3 boundary = new Vector3
            (
                Mathf.Clamp(targetPos.x, minPos.x, maxPos.x),
                Mathf.Clamp(targetPos.y, minPos.y, maxPos.y),
                Mathf.Clamp(targetPos.z, minPos.z, maxPos.z)
        );
        transform.position = boundary;
    }

    private void LateUpdate()
    {
        if (transform.position != player.position)
        {
            targetPos = player.position;

            Vector3 boundary = new Vector3
            (
                Mathf.Clamp(targetPos.x, minPos.x, maxPos.x),
                Mathf.Clamp(targetPos.y, minPos.y, maxPos.y),
                Mathf.Clamp(targetPos.z, minPos.z, maxPos.z)
            );

            newPos = Vector3.Lerp(transform.position, boundary, smoothSpeed);
            transform.position = newPos;
        }
    }
}
