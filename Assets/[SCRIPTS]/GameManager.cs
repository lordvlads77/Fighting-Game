using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _EndScreen = default;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
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
    }
}
