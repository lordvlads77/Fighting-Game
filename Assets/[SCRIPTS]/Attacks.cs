using UnityEngine;

public class Attacks : MonoBehaviour
{
     [SerializeField] private GameObject _smallFist = default;
     [SerializeField] private GameObject _mediumFist = default;
     [SerializeField] private GameObject _bigFist = default;
     [SerializeField] private KeyCode _lightAttack = default;
     [SerializeField] private KeyCode _mediumAttack = default;
     [SerializeField] private KeyCode _hardAttack = default;
     [SerializeField] private GameObject _ComboFist = default;
     [SerializeField] private KeyCode _ComboAttack = default;
     [SerializeField] private KeyCode _CombondKey = default;
     [SerializeField] private GameObject _blockFist = default;
     [SerializeField] private GameObject _Playercol = default;
     [SerializeField] private KeyCode _blockMove = default;
     private Animator anim = default;
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

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(_lightAttack))
        {
            _smallFist.SetActive(true);
            AnimationController.Instance.LightPunch(anim);
            GameObject lighthit = Instantiate(_hitEffectLightPunch, _leftHandsie.transform.position, _leftHandsie.transform.rotation);
        }
        if (Input.GetKeyUp(_lightAttack))
        {
            _smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(_ComboAttack))
        {
            _ComboFist.SetActive(true);
            AnimationController.Instance.ComboPunch(anim);
            GameObject vfxcombo = Instantiate(_EffectCombo, _legsie.transform.position, _legsie.transform.rotation);
        }
        if (Input.GetKeyUp(_ComboAttack))
        {
            _ComboFist.SetActive(false);
        }
        if (Input.GetKeyDown(_mediumAttack))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider>().enabled = false;
            _mediumFist.SetActive(true);
            AnimationController.Instance.MediumPuch(anim);
            GameObject mediumHit = Instantiate(_hitEffetMP, _RightHandise.transform.position,
                _RightHandise.transform.rotation);

        }
        if (Input.GetKeyUp(_mediumAttack))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider>().enabled = true;
            _mediumFist.SetActive(false);
        }
        if (Input.GetKeyDown(_hardAttack))
        {
            _smallFist.SetActive(true);
            _smallFist.GetComponent<BoxCollider>().enabled = false;
            _mediumFist.SetActive(true);
            _mediumFist.GetComponent<BoxCollider>().enabled = false;
            _bigFist.SetActive(true);
            AnimationController.Instance.HardPunch(anim);
            GameObject hardHit = Instantiate(_hitEffectHP, _leftHandsie.transform.position,
                _leftHandsie.transform.rotation);
        }
        if (Input.GetKeyUp(_hardAttack))
        {
            _smallFist.SetActive(false);
            _smallFist.GetComponent<BoxCollider>().enabled = true;
            _mediumFist.SetActive(false);
            _mediumFist.GetComponent<BoxCollider>().enabled = true;
            _bigFist.SetActive(false);
        }
        if (Input.GetKeyDown(_blockMove))
        {
            _blockFist.SetActive(true);
            AnimationController.Instance.Block(anim);
            GameObject block = Instantiate(_EffectBlock, _headsie.transform.position, _headsie.transform.rotation);
        }
        if (Input.GetKeyUp(_blockMove))
        {
            _blockFist.SetActive(false);
        }
    }
}
