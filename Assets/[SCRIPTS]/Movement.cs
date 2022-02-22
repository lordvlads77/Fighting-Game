using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private float _jumpSpeed = default;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Move(int direction)
    {
        transform.Translate(1 * _speed * Time.deltaTime, 0, 0);
    }
    void Jump()
    {
        
        transform.Translate(0, Time.deltaTime * _jumpSpeed, 0);
    }

}
