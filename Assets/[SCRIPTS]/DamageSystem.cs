using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "smallFist":
                GameManager.Instance.MinusLife(1);
                GameManager.Instance.MinusLifeGUI(1);
                break;
            
            case "mediumFist":
                GameManager.Instance.MinusLife(2);
                GameManager.Instance.MinusLifeGUI(2);
                break;
            
            case "bigFist":
                GameManager.Instance.MinusLife(3);
                GameManager.Instance.MinusLifeGUI(3);
                break;

            default:
                Debug.Log("good switch");
                break;
        }
    }
    
}
