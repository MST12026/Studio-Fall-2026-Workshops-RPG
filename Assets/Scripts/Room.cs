using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] Bounds roomBounds;
    List<Enemy> roomEnemies = new List<Enemy>();


    private void Start()
    { 
        Enemy[] enemies = FindObjectsByType<Enemy>();
        foreach (Enemy enemy in enemies) {
            if (roomBounds.Contains(enemy.transform.position))
            {
                roomEnemies.Add(enemy);
            }
        }

        Debug.Log(roomEnemies.Count);


        PlayerData p = FindAnyObjectByType<PlayerData>();
        if (roomBounds.Contains(p.transform.position)) {
            RoomManager.instance_.ForceSetActiveRoom(this);
            Debug.Log(this);
        }
        else
        {
            DeactivateRoom();
        }
    }


    public void RequestActiveRoom()
    {
        RoomManager.instance_.setActiveRoom(this);

        foreach (Enemy enemy in roomEnemies)
        {
            enemy.resetPosition();
            enemy.gameObject.SetActive(true);
        }
    }

    public void DeactivateRoom()
    {
        foreach (Enemy enemy in roomEnemies)
        {
            enemy.gameObject.SetActive(false);
        }
    }

    


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(roomBounds.center, roomBounds.size);
        roomBounds.center = transform.position;
    }

}
