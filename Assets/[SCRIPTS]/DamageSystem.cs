using System.Collections;
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
    
    [Header("Working Particules Sys")]
    [SerializeField] private GameObject _HaaP = default;
    [SerializeField] private GameObject _MeeP = default;
    [SerializeField] private GameObject _LiiP = default;
    [SerializeField] private GameObject _CooP = default;
    [SerializeField] private GameObject _BloodH = default;
    [SerializeField] private GameObject _BloodBody = default;

    [Header("Taking Damage Stuff")]
    [SerializeField] private Animator _animator = default;
    [SerializeField] private Attacks _attacks = default;
    [SerializeField] private float _ControlsDisTime = default;
    
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
                SoundController.Instance.LightHitSFX();
                if (_LiiP.CompareTag("LightHit"))
                {
                    ParticleController.Instance.spawnLightoPunch();
                }
                else if (_LiiP.CompareTag("smallfist2"))
                {
                    ParticleController.Instance.Light();
                }
                if (_BloodH.CompareTag("blood"))
                {
                    ParticleController.Instance.bloodshedHead();
                }
                else if (_BloodH.CompareTag("blood2"))
                {
                    ParticleController.Instance.BloHe();
                }
                if (_BloodBody.CompareTag("bloodbod"))
                {
                    ParticleController.Instance.BodBlood();
                }
                else if (_BloodBody.CompareTag("blood2"))
                {
                    ParticleController.Instance.BloyBod();
                }
                StartCoroutine(takinglightDamage());
                Debug.Log(StartCoroutine(takinglightDamage()));
                break;
            case "mediumFist":
                MinusLife(2);
                SoundController.Instance.MediumHitSFX();
                if (_MeeP.CompareTag("MediumHit"))
                {
                    ParticleController.Instance.spawnMediumPunch();
                }
                else if (_MeeP.CompareTag("mediumfist2"))
                {
                    ParticleController.Instance.Medium();
                }
                if (_BloodH.CompareTag("blood"))
                {
                    ParticleController.Instance.bloodshedHead();
                }
                else if (_BloodH.CompareTag("blood2"))
                {
                    ParticleController.Instance.BloHe();
                }
                if (_BloodBody.CompareTag("bloodbod"))
                {
                    ParticleController.Instance.BodBlood();
                }
                else if (_BloodBody.CompareTag("bloodbod2"))
                {
                    ParticleController.Instance.BloyBod();
                }
                break;
            case "bigFist":
                MinusLife(3);
                SoundController.Instance.HardHitSFX();
                ParticleController.Instance.bloodshedHead();
                if (_HaaP.CompareTag("HardHit"))
                {
                    ParticleController.Instance.spawnHardPunch();
                }
                else if (_HaaP.CompareTag("bigfist2"))
                {
                    ParticleController.Instance.Hard();
                }
                if (_BloodH.CompareTag("blood"))
                {
                    ParticleController.Instance.bloodshedHead();   
                }
                else if (_BloodH.CompareTag("blood2"))
                {
                    ParticleController.Instance.BloHe();
                }
                if (_BloodH.CompareTag("bloodbod"))
                {
                    ParticleController.Instance.BodBlood();
                }
                else if (_BloodH.CompareTag("bloodbod2"))
                {
                    ParticleController.Instance.BloyBod();
                }
                break;
            case "block":
                MinusLife(0);
                break;
            case "ComboFist":
                MinusLife(5);
                SoundController.Instance.KickMoveSFX();
                if (_CooP.CompareTag("ComboHits"))
                {
                    ParticleController.Instance.spawnCwKick();
                }
                else if (_CooP.CompareTag("combofist2"))
                {
                    ParticleController.Instance.Wombo();
                }

                if (_BloodH.CompareTag("blood"))
                {
                    ParticleController.Instance.bloodshedHead();
                }
                else if (_BloodH.CompareTag("blood2"))
                {
                    ParticleController.Instance.BloHe();
                }
                if (_BloodBody.CompareTag("bloodbod"))
                {
                    ParticleController.Instance.BodBlood();
                }
                else if (_BloodBody.CompareTag("bloodbod2"))
                {
                    ParticleController.Instance.BloyBod();
                }
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

    IEnumerator takinglightDamage()
    {
        AnimationController.Instance.TakingLightPunch(_animator);
        _attacks._smallFist.SetActive(false);
        _attacks.enabled = false;
        yield return new WaitForSeconds(_ControlsDisTime);
        _attacks.enabled = true;
        yield break;

    }
}
