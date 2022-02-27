using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private int life2 = default;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("smallFist"))
        {
            life2 --;
        }
        if (col.CompareTag("mediumFist"))
        {
            life2--;
            life2--;
        }
        if (col.CompareTag("bigFist"))
        {
            life2--;
            life2--;
            life2--;
        }
    }
}
