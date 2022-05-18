using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _EndScreen = default;
    [SerializeField] private AudioSource _lobbyMusicAgain = default;
    [SerializeField] private AudioSource _noMoreBattleMusic = default;
    public static GameManager Instance { get; private set; }
    
    private void Awake()
    {
        FindObjectOfType<TextMeshProUGUI>();
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    public void PlayerDeath(int playerNumber)
    {
        Debug.Log($"Player Death: {playerNumber}");
        _EndScreen.SetActive(true);
        Time.timeScale = 0;
        GUI.Instance._battleMusic.enabled = false;
        GUI.Instance._lobbyMusic.enabled = true;
    }

    public void PlayerWin(TextMeshProUGUI _winnerName, int playerNumber, int _playerWinner)
    {
        if (playerNumber == 1)
        {
            _playerWinner = 2;
        }
        else if (playerNumber != 1)
        {
            _playerWinner = 1;
        }
        _winnerName.text = $"Player {_playerWinner}!!";
    }
    
}
