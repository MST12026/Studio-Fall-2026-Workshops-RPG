using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager instance_;
    Room activeRoom;
    public PlayerData player_;

    void Awake()
    {
        player_ = FindAnyObjectByType<PlayerData>();
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
