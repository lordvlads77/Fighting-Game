using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private int _jumpSpeed = default;

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
    }

    void Move(int direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime, 0, 0);
    }
    
    void Jump()
    {   
        transform.Translate(0, _jumpSpeed * _speed * Time.deltaTime, 0);
    }
}
