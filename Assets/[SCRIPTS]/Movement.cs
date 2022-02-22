using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private float _jumpspeed = default;
    [SerializeField] private float _movement = default;

    

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Move();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 3 * Time.deltaTime * _jumpspeed, 0);
        }
    }

    void Move()
    {
        transform.Translate(1 * _speed * Time.deltaTime, 0, 0);
    }
}
