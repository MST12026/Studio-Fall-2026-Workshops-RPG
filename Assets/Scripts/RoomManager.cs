using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager instance_;
    Room activeRoom;

    void Awake()
    {
        instance_ = this;
    }

    public void setActiveRoom(Room room)
    {
        activeRoom.DeactivateRoom();
        activeRoom = room;
    }

    public void ForceSetActiveRoom(Room room)
    {
        activeRoom = room;
    }
}
