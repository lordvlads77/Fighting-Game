using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public  static ParticleController Instance { get; private set; }
    [Header("hardPunch Stuff")]
    [SerializeField] private Transform _hardPunchie = default;
    [SerializeField] private GameObject _hardPunchieVFX = default;
    [Header("Medium Punch VFX")]
    [SerializeField] private GameObject _mPunchieVFX = default;
    [SerializeField] private Transform _MedPunchies = default;
    [Header("Light Punch VFX")]
    [SerializeField] private GameObject _lghtPunchieVFX = default;
    [SerializeField] private Transform _lPunchies = default;
    [Header("Combo Wombo VFX")]
    [SerializeField] private GameObject _comboWomboVFX = default;
    [SerializeField] private Transform _CWPunchies = default;
    [Header("Block VFX")]
    [SerializeField] private GameObject _blocksieVFX = default;
    [SerializeField] private Transform _blckPunchie = default;
    [Header("Blood Head VFX")]
    [SerializeField] private GameObject _blodSpwanVFX = default;
    [SerializeField] private Transform _bloodsieSpawnear = default;
    [Header("Blood Body VFX")]
    [SerializeField] private GameObject _bloodBodyVFX = default;
    [SerializeField] private Transform _bodyBlood = default;

    private void Awake()
    {
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void spawnHardPunch()
    {
        GameObject SpawnerHardHit = Instantiate(_hardPunchieVFX, _hardPunchie.position, _hardPunchie.rotation);
    }

    public void spawnMediumPunch()
    {
        GameObject SpawnerMPunch = Instantiate(_mPunchieVFX, _MedPunchies.position, _MedPunchies.rotation);
    }

    public void spawnLightoPunch()
    {
        GameObject SpawnerLightoPunch = Instantiate(_lghtPunchieVFX, _lPunchies.position, _lPunchies.rotation);
    }

    public void spawnCwKick()
    {
        GameObject KickComboW = Instantiate(_comboWomboVFX, _CWPunchies.position, _CWPunchies.rotation);
    }

    public void blok()
    {
        GameObject blck = Instantiate(_blocksieVFX, _blckPunchie.position, _blckPunchie.rotation);
    }

    public void bloodshedHead()
    {
        GameObject headBlood = Instantiate(_blodSpwanVFX, _bloodsieSpawnear.position, _bloodsieSpawnear.rotation);
    }

    public void BodBlood()
    {
        GameObject Bloodbod = Instantiate(_bloodBodyVFX, _bodyBlood.position, _bodyBlood.rotation);
    }
}
