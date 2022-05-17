using System;
using UnityEngine;
using KnightBrawlers;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = default;
    [SerializeField] private int _jumpSpeed = default;
    [SerializeField] public GameObject _screenPause = default;
    [SerializeField] private KeyCode _horizontalL = default;
    [SerializeField] private KeyCode _horizontalR = default;
    [SerializeField] private KeyCode _jumpL = default;
    [SerializeField] private KeyCode _pause = default;
    [SerializeField] private KeyCode _flipCharacter = default;
    
    [Header("Animation Stuff")]
    [SerializeField] private Animator _animator = default;
    private readonly int _ahSpeed = Animator.StringToHash("speed");
    private readonly int _ahJump = Animator.StringToHash("jump");
    
    [Header("Check Ground")]
    [SerializeField] private Vector3 _checkGroundP;
    [SerializeField] private bool _isGroud;
    [SerializeField] private float _checkGroundR;
    [SerializeField] private LayerMask _checkGroundM;
    
    [Header("Jump Stuff")]
    private Vector3 _movement;
    [SerializeField] private Rigidbody _rigidbody;
    private void FixedUpdate()
    {
        _isGroud = Physics.CheckSphere(transform.position + _checkGroundP, _checkGroundR, _checkGroundM);
        _movement = transform.TransformDirection(_movement);
        _movement.y = _rigidbody.velocity.y;
        _rigidbody.velocity = _movement;
    }

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
        if (Input.GetKey(_jumpL) && _isGroud)
        {
            Jump();
            _animator.SetTrigger(_ahJump);
        }
        if (Input.GetKeyDown(_pause))
        {
            Pause();
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
        //transform.Translate(0, _jumpSpeed * Time.deltaTime, 0);
        _rigidbody.AddForce(Vector3.up * _jumpSpeed);
    }

    public void Pause()
    {
        _screenPause.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
    }
}
