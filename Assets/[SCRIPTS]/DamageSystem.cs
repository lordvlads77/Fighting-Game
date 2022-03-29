using UnityEngine;
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{
    [Header("LifeSystem")]
    [SerializeField] private int _playerNumber = default;
    [SerializeField] private int _life = default;
    [SerializeField] private Slider _healthSlider = default;
    
    public void MinusLife(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _life--;
            if (_life <= 0)
            {
                GameManager.Instance.PlayerDeath(_playerNumber);
            }
        }
    }

    public void UpdateSlider()
    {
        _healthSlider.value = _life;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "smallFist":
                MinusLife(1);
                break;
            case "mediumFist":
                MinusLife(2);
                break;
            case "bigFist":
                MinusLife(3);
                break;
            case "block":
                MinusLife(0);
                break;
            default:
                break;
        }

        UpdateSlider();
    }
}
