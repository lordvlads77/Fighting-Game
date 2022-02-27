using UnityEngine;

public class Attacks : MonoBehaviour
{
     [SerializeField] private GameObject smallFist;
     [SerializeField] private GameObject mediumFist;
     [SerializeField] private GameObject bigFist;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            smallFist.SetActive(true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            smallFist.SetActive(true);
            smallFist.GetComponent<BoxCollider2D>().enabled = false;
            mediumFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            smallFist.SetActive(false);
            smallFist.GetComponent<BoxCollider2D>().enabled = true;
            mediumFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            smallFist.SetActive(true);
            smallFist.GetComponent<BoxCollider2D>().enabled = false;
            mediumFist.SetActive(true);
            mediumFist.GetComponent<BoxCollider2D>().enabled = false;
            bigFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            smallFist.SetActive(false);
            smallFist.GetComponent<BoxCollider2D>().enabled = true;
            mediumFist.SetActive(false);
            mediumFist.GetComponent<BoxCollider2D>().enabled = true;
            bigFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            smallFist.SetActive(true);
            smallFist.GetComponent<BoxCollider2D>().enabled = false;
            mediumFist.SetActive(true);
            mediumFist.GetComponent<BoxCollider2D>().enabled = false;
            bigFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            smallFist.SetActive(false);
            smallFist.GetComponent<BoxCollider2D>().enabled = true;
            mediumFist.SetActive(false);
            mediumFist.GetComponent<BoxCollider2D>().enabled = true;
            bigFist.SetActive(false);
        }
    }
}
