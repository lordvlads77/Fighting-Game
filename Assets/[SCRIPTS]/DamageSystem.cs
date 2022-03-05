using UnityEngine;
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private int life = default;
    [SerializeField] private Slider _healthSlider = default;
    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "smallFist":
                ReduceLife(1);
                ReduceLifeUI(1);
                break;
            
            case "mediumFist":
                ReduceLife(2);
                ReduceLifeUI(2);
                break;
            
            case "bigFist":
                ReduceLife(3);
                ReduceLifeUI(3);
                break;

            default:
                Debug.Log("che switch");
                break;
        }
    }

    private void ReduceLife(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            life--;
        }
    }

    private void ReduceLifeUI(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _healthSlider.value--;
        }
    }
}
