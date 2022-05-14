using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private int _jumpSpeed = default;
    [SerializeField] private KeyCode _horizontalL = default;
    [SerializeField] private KeyCode _horizontalR = default;
    [SerializeField] private KeyCode _jumpL = default;
    [SerializeField] private KeyCode _pause = default;
    [SerializeField] private KeyCode _flipCharacter = default;
    
    [Header("Animation Stuff")]
    [SerializeField] private Animator _animator = default;
    private readonly int _ahSpeed = Animator.StringToHash("speed");
    private readonly int _ahJump = Animator.StringToHash("jump");

    void Update()
    {
        if (Input.GetKey(_horizontalL))
        {
            Move(-1);
            _animator.SetInteger(_ahSpeed, 2);
        }
        if (Input.GetKeyDown(_flipCharacter))
        {
            transform.Rotate(0, 180, 0);
        }
        if (Input.GetKeyUp(_horizontalL))
        {
            _animator.SetInteger(_ahSpeed, 1);
        }
        if (Input.GetKey(_horizontalR))
        {
            Move(1);
            _animator.SetInteger(_ahSpeed, 4);
        }
        if (Input.GetKeyDown(_jumpL))
        {
            Jump();
            _animator.SetTrigger(_ahJump);
        }
        if (Input.GetKeyDown(_pause))
        {
            GUI.Instance.Pause();
        }
        if (Input.GetKeyUp(_horizontalR))
        {
            _animator.SetInteger(_ahSpeed, 0);
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
}
