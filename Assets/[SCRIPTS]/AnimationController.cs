using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController Instance { get; private set; }
    [SerializeField] private Animator _anim = default;
    private readonly int _ahLpunch = Animator.StringToHash("lightPunch");
    private readonly int _ahMpunch = Animator.StringToHash("mediumPunch");
    private readonly int _ahHpunch = Animator.StringToHash("hardPunch");
    private readonly int _ahCombopunch = Animator.StringToHash("comboPunch");
    private readonly int _ahBlock = Animator.StringToHash("block");
    private readonly int _ahSpeed = Animator.StringToHash("speed");
    private readonly int _ahJump = Animator.StringToHash("jump");

    [Header("Reference")]
    Movement movement;
    private void Awake()
    {
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void LightPunch()
    {
        _anim.SetTrigger(_ahLpunch);    
    }

    public void MediumPuch()
    {
        _anim.SetTrigger(_ahMpunch);
    }

    public void HardPunch()
    {
        _anim.SetTrigger(_ahHpunch);
    }

    public void ComboPunch()
    {
        _anim.SetTrigger(_ahCombopunch);
    }

    public void Block()
    {
        _anim.SetTrigger(_ahBlock);
    }
}
