using UnityEngine;
using UnityEngine.Serialization;

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
    [Header("Block GameObj")]
    [SerializeField] private GameObject _blockk = default;
    [Header("Blood Head VFX")]
    [SerializeField] private GameObject _blodSpwanVFX = default;
    [SerializeField] private Transform _bloodsieSpawnear = default;
    [Header("Blood Body VFX")]
    [SerializeField] private GameObject _bloodBodyVFX = default;
    [SerializeField] private Transform _bodyBlood = default;
    
    [FormerlySerializedAs("_hardPunchie")]
    [Header("Player 2")]
    [SerializeField] private Transform _hardPunchie2 = default;
    [SerializeField] private GameObject _hardPunchieVFX2 = default;
    [Header("Medium Punch VFX")]
    [SerializeField] private GameObject _mPunchieVFX2 = default;
    [SerializeField] private Transform _MedPunchies2 = default;
    [Header("Light Punch VFX")]
    [SerializeField] private GameObject _lghtPunchieVFX2 = default;
    [SerializeField] private Transform _lPunchies2 = default;
    [Header("Combo Wombo VFX")]
    [SerializeField] private GameObject _comboWomboVFX2 = default;
    [SerializeField] private Transform _CWPunchies2 = default;
    [Header("Block GameObj")]
    [SerializeField] private GameObject _blockk2 = default;
    [Header("Blood Head VFX")]
    [SerializeField] private GameObject _blodSpwanVFX2 = default;
    [SerializeField] private Transform _bloodsieSpawnear2 = default;
    [Header("Blood Body VFX")]
    [SerializeField] private GameObject _bloodBodyVFX2 = default;
    [SerializeField] private Transform _bodyBlood2 = default;
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
        _blockk.SetActive(true);
    }

    public void StopBlocking()
    {
        _blockk.SetActive(false);
    }
    
    public void bloodshedHead()
    {
        GameObject headBlood = Instantiate(_blodSpwanVFX, _bloodsieSpawnear.position, _bloodsieSpawnear.rotation);
    }

    public void BodBlood()
    {
        GameObject Bloodbod = Instantiate(_bloodBodyVFX, _bodyBlood.position, _bodyBlood.rotation);
    }
    public void spawnHardPunch2()
    {
        GameObject SpawnerHardHit2 = Instantiate(_hardPunchieVFX2, _hardPunchie2.position, _hardPunchie2.rotation);
    }

    public void spawnMediumPunch2()
    {
        GameObject SpawnerMPunch2 = Instantiate(_mPunchieVFX2, _MedPunchies2.position, _MedPunchies2.rotation);
    }

    public void spawnLightoPunch2()
    {
        GameObject SpawnerLightoPunch2 = Instantiate(_lghtPunchieVFX2, _lPunchies2.position, _lPunchies2.rotation);
    }

    public void spawnCwKick2()
    {
        GameObject KickComboW2 = Instantiate(_comboWomboVFX2, _CWPunchies2.position, _CWPunchies2.rotation);
    }

    public void blok2()
    {
        _blockk2.SetActive(true);
    }

    public void StopBlocking2()
    {
        _blockk2.SetActive(false);
    }
    
    public void bloodshedHead2()
    {
        GameObject headBlood2 = Instantiate(_blodSpwanVFX2, _bloodsieSpawnear2.position, _bloodsieSpawnear2.rotation);
    }

    public void BodBlood2()
    {
        GameObject Bloodbod2 = Instantiate(_bloodBodyVFX2, _bodyBlood2.position, _bodyBlood2.rotation);
    }
}
