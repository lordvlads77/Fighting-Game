using UnityEngine;

public class Attacks2 : MonoBehaviour
{
    [SerializeField] private GameObject _smallFist2 = default;
    [SerializeField] private GameObject _mediumFist2 = default;
    [SerializeField] private GameObject _bigFist2 = default;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            _smallFist2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            _smallFist2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            _smallFist2.SetActive(true);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            _smallFist2.SetActive(false);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            _smallFist2.SetActive(true);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist2.SetActive(true);
            _mediumFist2.GetComponent<BoxCollider2D>().enabled = false;
            _bigFist2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            _smallFist2.SetActive(false);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist2.SetActive(false);
            _mediumFist2.GetComponent<BoxCollider2D>().enabled = true;
            _bigFist2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            _smallFist2.SetActive(true);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist2.SetActive(true);
            _mediumFist2.GetComponent<BoxCollider2D>().enabled = false;
            _bigFist2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Keypad9))
        {
            _smallFist2.SetActive(false);
            _smallFist2.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist2.SetActive(false);
            _mediumFist2.GetComponent<BoxCollider2D>().enabled = true;
            _bigFist2.SetActive(false);
        }
    }
}
