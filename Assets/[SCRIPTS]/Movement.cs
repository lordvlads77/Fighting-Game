using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private int _jumpSpeed = default;
    [SerializeField] public GameObject _ScreenPause = default;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(-1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _ScreenPause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Move(int direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime, 0, 0);
    }
    
    public void Jump()
    {   
        transform.Translate(0, _jumpSpeed * _speed * Time.deltaTime, 0);
    }
}
