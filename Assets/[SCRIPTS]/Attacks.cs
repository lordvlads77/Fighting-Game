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
     [Header("Sounds Sys")]
     [SerializeField] private AudioSource _battleCriesSFX = default;
     [SerializeField] private AudioClip _battleCryLM = default;
     [SerializeField] private AudioClip _battleCryH = default;
     [SerializeField] private AudioClip _battleCryK = default;

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
            _battleCriesSFX.PlayOneShot(_battleCryLM, 1f);
        }
        if (Input.GetKeyUp(_lightAttack))
        {
            _smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(_ComboAttack))
        {
            _ComboFist.SetActive(true);
            AnimationController.Instance.ComboPunch(anim);
            _battleCriesSFX.PlayOneShot(_battleCryK, 1f);
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
            _battleCriesSFX.PlayOneShot(_battleCryLM, 1f);

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
            _battleCriesSFX.PlayOneShot(_battleCryH, 1f);
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
        }
        if (Input.GetKeyUp(_blockMove))
        {
            _blockFist.SetActive(false);
        }
    }
}
