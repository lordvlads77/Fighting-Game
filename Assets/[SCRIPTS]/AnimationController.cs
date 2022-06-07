using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController Instance { get; private set; }
    private readonly int _ahLpunch = Animator.StringToHash("lightPunch");
    private readonly int _ahMpunch = Animator.StringToHash("mediumPunch");
    private readonly int _ahHpunch = Animator.StringToHash("hardPunch");
    private readonly int _ahCombopunch = Animator.StringToHash("comboPunch");
    private readonly int _ahSpeed = Animator.StringToHash("speed");
    private readonly int _ahJump = Animator.StringToHash("jump");
    private readonly int _aTakingSmallP = Animator.StringToHash("takingSP");
    private readonly int _aTakingMediumP = Animator.StringToHash("takingMP");
    private readonly int _aTakingBigP = Animator.StringToHash("takingGP");
    private readonly int _aTakingCP = Animator.StringToHash("takingCP");

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

    public void LightPunch(Animator animm)
    {
        animm.SetTrigger(_ahLpunch);
    }

    public void MediumPuch(Animator animm)
    {
        animm.SetTrigger(_ahMpunch);
    }

    public void HardPunch(Animator animm)
    {
        animm.SetTrigger(_ahHpunch);
    }

    public void ComboPunch(Animator animm)
    {
        animm.SetTrigger(_ahCombopunch);
    }
    
    public void TakingLightPunch(Animator animm)
    {
        animm.SetTrigger(_aTakingSmallP);
    }

    public void TakingMediumPunch(Animator animm)
    {
        animm.SetTrigger(_aTakingMediumP);
    }

    public void TakingHardPunch(Animator animm)
    {
        animm.SetTrigger(_aTakingBigP);
    }

    public void TakingComboPunch(Animator animm)
    {
        animm.SetTrigger(_aTakingCP);
    }
}
