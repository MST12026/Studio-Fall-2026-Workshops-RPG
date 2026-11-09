using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager instance_;
    Room activeRoom;


    void Start()
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
