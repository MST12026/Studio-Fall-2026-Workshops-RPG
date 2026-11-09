using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    public float smoothSpeed;

    private Vector3 targetPos, newPos;

    public Vector3 minPos, maxPos;

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
