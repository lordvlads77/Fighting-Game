using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private int life = default;
    private void OnTriggerEnter2D(Collider2D col)
    {
       /* if (col.CompareTag("smallFist"))
        {
            ReduceLife(1);
        }
        if (col.CompareTag("mediumFist"))
        {
            ReduceLife(2);
        }
        if (col.CompareTag("bigFist"))
        { 
            ReduceLife(3);
        }*/

        switch (col.gameObject.tag)
        {
            case "smallFist":
                ReduceLife(1);
                break;
            
            case "mediumFist":
                ReduceLife(2);
                break;
            
            case "bigFist":
                ReduceLife(3);
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
}
