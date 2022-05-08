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
                break;
            case "mediumFist":
                MinusLife(2);
                _punchesSFX.PlayOneShot(_medHitSfx, 1f);
                break;
            case "bigFist":
                MinusLife(3);
                _punchesSFX.PlayOneShot(_hardHittSfx, 1f);
                break;
            case "block":
                MinusLife(0);
                break;
            case "ComboFist":
                MinusLife(5);
                _punchesSFX.PlayOneShot(_kickSfx, 1f);
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
