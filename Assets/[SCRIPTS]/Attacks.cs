using UnityEngine;

public class Attacks : MonoBehaviour
{
     [SerializeField] private GameObject _smallFist = default;
     [SerializeField] private GameObject _mediumFist = default;
     [SerializeField] private GameObject _bigFist = default;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _smallFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist.SetActive(true);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = false;
            _bigFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist.SetActive(false);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = true;
            _bigFist.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist.SetActive(true);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = false;
            _bigFist.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist.SetActive(false);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = true;
            _bigFist.SetActive(false);
        }
    }
}
