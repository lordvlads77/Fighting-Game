using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance { get; private set; }
    [Header("Battle Cries SFX")]
    [SerializeField] private AudioSource _battleCriesSFX = default;
    [SerializeField] private AudioClip _battleCryLM = default;
    [SerializeField] private AudioClip _battleCryH = default;
    [SerializeField] private AudioClip _battleCryK = default;
    
    [Header("Punches SFX")]
    [SerializeField] private AudioSource _punchesSFX = default;
    [SerializeField] private AudioClip _lightHittSFX = default;
    [SerializeField] private AudioClip _medHitSfx = default;
    [SerializeField] private AudioClip _hardHittSfx = default;
    [SerializeField] private AudioClip _kickSfx = default; 
    private void Awake()
    {
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void BattleCryLightMedium()
    {
        _battleCriesSFX.PlayOneShot(_battleCryLM, 1f);
    }

    public void HardPunchBattleCry()
    {
        _battleCriesSFX.PlayOneShot(_battleCryH, 1f);
    }

    public void ComboBattleCry()
    {
        _battleCriesSFX.PlayOneShot(_battleCryK, 1f);
    }

    public void LightHitSFX()
    {
        _punchesSFX.PlayOneShot(_lightHittSFX, 1f);
    }

    public void MediumHitSFX()
    {
        _punchesSFX.PlayOneShot(_medHitSfx, 1f);
    }

    public void HardHitSFX()
    {
        _punchesSFX.PlayOneShot(_hardHittSfx, 1f);
    }

    public void KickMoveSFX()
    {
        _punchesSFX.PlayOneShot(_kickSfx, 1f);
    }
}
