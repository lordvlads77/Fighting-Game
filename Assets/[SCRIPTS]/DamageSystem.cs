using UnityEngine;
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private int _life = default;
    [SerializeField] private Slider _healthSlider = default;
    [SerializeField] private GameObject _EndScreen = default;
    [SerializeField] private GameObject _PlayerScriptDeath = default;

    private void Update()
    {
        if (_life <= 0)
        {
            _EndScreen.SetActive(true);
            _PlayerScriptDeath.GetComponent<Movement>().enabled = false;
            _PlayerScriptDeath.GetComponent<Attacks>().enabled = false;
        }
    }

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
            _life--;
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
