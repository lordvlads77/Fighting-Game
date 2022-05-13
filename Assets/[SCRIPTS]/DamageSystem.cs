using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{
    [Header("LifeSystem")]
    [SerializeField] private int _playerNumber = default;
    [SerializeField] private int _life = default;
    [SerializeField] private Slider _healthSlider = default;
    
    [Header("Dynamic Win Sys")]
    [SerializeField] private TextMeshProUGUI _winnerName = default;
    [SerializeField] private int _PlayerWinner = default;
    
    [Header("Sound System")]
    [SerializeField] private AudioSource _punchesSFX = default;
    [SerializeField] private AudioClip _lightHittSFX = default;
    [SerializeField] private AudioClip _medHitSfx = default;
    [SerializeField] private AudioClip _hardHittSfx = default;
    [SerializeField] private AudioClip _kickSfx = default;
    [Header("Light Punch Particles")]
    [SerializeField] private GameObject _hitEffectLightPunch = default;
    [SerializeField] private Transform _leftHandsie = default;
    [Header("Medium Punch Particles")]
    [SerializeField] private GameObject _hitEffetMP = default;
    [SerializeField] private Transform _RightHandise = default;
    [Header("Hard Punch Particles")]
    [SerializeField] private GameObject _hitEffectHP = default;
    [Header("Block Particles")]
    [SerializeField] private GameObject _EffectBlock = default;
    [SerializeField] private Transform _headsie = default;
    [Header("Combo Particles")]
    [SerializeField] private GameObject _EffectCombo = default;
    [SerializeField] private Transform _legsie = default;

    private void Start()
    {
        _punchesSFX = GetComponent<AudioSource>();
    }

    public void MinusLife(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _life--;
            if (_life <= 0)
            {
                GameManager.Instance.PlayerDeath(_playerNumber);
                WinnerUIChange();
            }
        }
    }

    public void UpdateSlider()
    {
        _healthSlider.value = _life;
    }

    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "smallFist":
                MinusLife(1);
                _punchesSFX.PlayOneShot(_lightHittSFX, 1f);
                GameObject lighthit = Instantiate(_hitEffectLightPunch, _leftHandsie.transform.position, _leftHandsie.transform.rotation);
                break;
            case "mediumFist":
                MinusLife(2);
                _punchesSFX.PlayOneShot(_medHitSfx, 1f);
                GameObject mediumHit = Instantiate(_hitEffetMP, _RightHandise.transform.position,
                _RightHandise.transform.rotation);
                break;
            case "bigFist":
                MinusLife(3);
                _punchesSFX.PlayOneShot(_hardHittSfx, 1f);
                GameObject hardHit = Instantiate(_hitEffectHP, _leftHandsie.transform.position,_leftHandsie.transform.rotation);
                break;
            case "block":
                MinusLife(0);
                GameObject block = Instantiate(_EffectBlock, _headsie.transform.position, _headsie.transform.rotation);
                break;
            case "ComboFist":
                MinusLife(5);
                _punchesSFX.PlayOneShot(_kickSfx, 1f);
                GameObject vfxcombo = Instantiate(_EffectCombo, _legsie.transform.position, _legsie.transform.rotation);
                break;
            default:
                break;
        }
        UpdateSlider();
    }
    
    public void WinnerUIChange()
    {
        GameManager.Instance.PlayerWin(_winnerName, _playerNumber, _PlayerWinner);
    }
}
