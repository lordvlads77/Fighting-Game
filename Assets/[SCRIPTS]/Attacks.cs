using UnityEngine;

public class Attacks : MonoBehaviour
{
     [SerializeField] private GameObject _smallFist = default;
     [SerializeField] private GameObject _mediumFist = default;
     [SerializeField] private GameObject _bigFist = default;
     [SerializeField] private GameObject _ComboFist = default;
     [SerializeField] private KeyCode _lightAttack = default;
     [SerializeField] private KeyCode _mediumAttack = default;
     [SerializeField] private KeyCode _hardAttack = default;
     [SerializeField] private KeyCode _ComboAttack = default;
     [SerializeField] private KeyCode _CombondKey = default;

     void Update()
    {
        if (Input.GetKeyDown(_lightAttack))
        {
            _smallFist.SetActive(true);
        }
        if (Input.GetKeyUp(_lightAttack))
        {
            _smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(_ComboAttack) && (Input.GetKeyDown(_CombondKey)))
        {
            _ComboFist.SetActive(true);
        }
        if (Input.GetKeyUp(_ComboAttack))
        {
            _ComboFist.SetActive(false);
        }
        if (Input.GetKeyDown(_mediumAttack))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist.SetActive(true);
        }
        if (Input.GetKeyUp(_mediumAttack))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist.SetActive(false);
        }
        if (Input.GetKeyDown(_hardAttack))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider2D>().enabled = false;
            _mediumFist.SetActive(true);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = false;
            _bigFist.SetActive(true);
        }
        if (Input.GetKeyUp(_hardAttack))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider2D>().enabled = true;
            _mediumFist.SetActive(false);
            _mediumFist.GetComponent<BoxCollider2D>().enabled = true;
            _bigFist.SetActive(false);
        }
    }
}
