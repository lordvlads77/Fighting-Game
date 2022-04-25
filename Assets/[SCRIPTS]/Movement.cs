using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private int _jumpSpeed = default;
    [SerializeField] public GameObject _screenPause = default;
    [SerializeField] private KeyCode _horizontalL = default;
    [SerializeField] private KeyCode _horizontalR = default;
    [SerializeField] private KeyCode _jumpL = default;
    [SerializeField] private KeyCode _pause = default;

    void Update()
    {
        if (Input.GetKey(_horizontalL))
        {
            Move(-1);
        }
        if (Input.GetKey(_horizontalR))
        {
            Move(1);
        }
        if (Input.GetKeyDown(_jumpL))
        {
            Jump();
        }
        if (Input.GetKeyDown(_pause))
        {
            Pause();
        }
    }

    public void Move(int direction)
    {
        transform.Translate(0, 0, direction * _speed * Time.deltaTime);
    }
    
    public void Jump()
    {   
        transform.Translate(0, _jumpSpeed * _speed * Time.deltaTime, 0);
    }

    public void Pause()
    {
        _screenPause.SetActive(true);
        Time.timeScale = 0;
    }
}
