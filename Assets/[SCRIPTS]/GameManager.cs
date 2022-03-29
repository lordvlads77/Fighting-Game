using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("LifeSystem")]
    [SerializeField] private int _life = default;
    [SerializeField] private Slider _healthSlider = default;

    
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
    
    public void PlayerDeath(int amount)
    {
        if (_life <= 0)
        {
            _EndScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void MinusLife(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _life--;
        }
    }

    public void MinusLifeGUI(int amount)
    {
        _healthSlider.value--;
    }
}
