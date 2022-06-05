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
    [Header("Block GameObj")]
    [SerializeField] private GameObject _blockk = default;
    [Header("Blood Head VFX")]
    [SerializeField] private GameObject _blodSpwanVFX = default;
    [SerializeField] private Transform _bloodsieSpawnear = default;
    [Header("Blood Body VFX")]
    [SerializeField] private GameObject _bloodBodyVFX = default;
    [SerializeField] private Transform _bodyBlood = default;

    [Header("Block GameObj")]
    [SerializeField] private GameObject _blockk2 = default;
    
    [Header("Hard Punch P2")]
    [SerializeField] private Transform _harde = default;
    [SerializeField] private GameObject _hardeFX = default;
    [Header("Medium Punch P2")]
    [SerializeField] private Transform _mediu = default;
    [SerializeField] private GameObject _mediuFX = default;
    [Header("Light Punch P2")]
    [SerializeField] private Transform _ligt = default;
    [SerializeField] private GameObject _ligtFX = default;
    [Header("Combo Punch P2")]
    [SerializeField] private Transform _combo = default;
    [SerializeField] private GameObject _comboFX = default;
    [Header("Bloodshed Head")]
    [SerializeField] private Transform _headBloodd = default;
    [SerializeField] private GameObject _headBloodFX = default;
    [Header("Bloodshed Body P2")]
    [SerializeField] private Transform _bloodyBody = default;
    [SerializeField] private GameObject _bloodyBodyFX = default;

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
    
    public void blok2()
    {
        _blockk2.SetActive(true);
    }

    public void StopBlocking2()
    {
        _blockk2.SetActive(false);
    }

    public void Hard()
    {
        GameObject HaP = Instantiate(_hardeFX, _harde.position, _harde.rotation);
    }

    public void Medium()
    {
        GameObject MaP = Instantiate(_mediuFX, _mediu.position, _mediu.rotation);
    }

    public void Light()
    {
        GameObject LaP = Instantiate(_ligtFX, _ligt.position, _ligt.rotation);
    }

    public void Wombo()
    {
        GameObject CaP = Instantiate(_comboFX, _combo.position, _combo.rotation);
    }

    public void BloHe()
    {
        GameObject HeBlod = Instantiate(_headBloodFX, _headBloodd.position, _headBloodd.rotation);
    }

    public void BloyBod()
    {
        GameObject BodBloy = Instantiate(_bloodyBodyFX, _bloodyBody.position, _bloodyBody.rotation);
    }
}
