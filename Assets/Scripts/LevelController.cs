using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Transform FirstRoomTransform;
    public Transform Player;

    private Transform _roomWithPlayer;

    void Awake()
    {
        _roomWithPlayer = FirstRoomTransform;
    }
    
    public void Teleport(Transform roomTransform)
    {
        var offset = Player.position - _roomWithPlayer.position;
        _roomWithPlayer = roomTransform;
        Player.transform.position = roomTransform.position + offset;
    }
}
