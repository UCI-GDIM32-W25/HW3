using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;

    // you can use this to access the player object from any other script!
    public Player _Player => _player;
}