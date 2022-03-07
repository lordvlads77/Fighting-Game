using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    [SerializeField] private float _speed2 = default;
    [SerializeField] private int _jumpSpeed2 = default;
    [SerializeField] public GameObject _ScreenPause2 = default;
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            Move2(-1);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            Move2(1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Jump2();   
        }
        if (Input.GetKeyDown(KeyCode.Insert))
        {
            _ScreenPause2.SetActive(true);
            Time.timeScale = 0;
        }               
    }
    
    public void Move2(int direction)
    {
        transform.Translate(direction * _speed2 * Time.deltaTime, 0, 0);
    }
    
    public void Jump2()
    {   
        transform.Translate(0, _jumpSpeed2 * _speed2 * Time.deltaTime, 0);
    }
}
