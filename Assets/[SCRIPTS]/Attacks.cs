using UnityEngine;

public class Attacks : MonoBehaviour
{
     [SerializeField] public GameObject _smallFist = default;
     [SerializeField] public GameObject _mediumFist = default;
     [SerializeField] public GameObject _bigFist = default;
     [SerializeField] private KeyCode _lightAttack = default;
     [SerializeField] private KeyCode _mediumAttack = default;
     [SerializeField] private KeyCode _hardAttack = default;
     [SerializeField] public GameObject _ComboFist = default;
     [SerializeField] private KeyCode _ComboAttack = default;
     [SerializeField] private KeyCode _CombondKey = default;
     [SerializeField] private GameObject _blockFist = default;
     [SerializeField] private GameObject _Playercol = default;
     [SerializeField] private KeyCode _blockMove = default;
     [SerializeField] private GameObject _blockob = default;
     private Animator anim = default;


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
            SoundController.Instance.BattleCryLightMedium();
        }
        if (Input.GetKeyUp(_lightAttack))
        {
            _smallFist.SetActive(false);
        }
        if (Input.GetKeyDown(_ComboAttack))
        {
            _ComboFist.SetActive(true);
            AnimationController.Instance.ComboPunch(anim);
            SoundController.Instance.ComboBattleCry();
        }
        if (Input.GetKeyUp(_ComboAttack))
        {
            _ComboFist.SetActive(false);
        }
        if (Input.GetKeyDown(_mediumAttack))
        {
            //_smallFist.SetActive(true);
            //_smallFist.GetComponent<BoxCollider>().enabled = false;
            _mediumFist.SetActive(true);
            AnimationController.Instance.MediumPuch(anim);
            SoundController.Instance.BattleCryLightMedium();

        }
        if (Input.GetKeyUp(_mediumAttack))
        {
            //_smallFist.GetComponent<BoxCollider>().enabled = true;
            //_smallFist.SetActive(false);
            _mediumFist.SetActive(false);
        }
        if (Input.GetKeyDown(_hardAttack))
        {
            _bigFist.SetActive(true);
            AnimationController.Instance.HardPunch(anim);
            SoundController.Instance.HardPunchBattleCry();
        }
        if (Input.GetKeyUp(_hardAttack))
        {
            _bigFist.SetActive(false);
        }
        if (Input.GetKeyDown(_blockMove))
        {
            _blockFist.SetActive(true);
            if (_blockob.CompareTag("block"))
            {
                ParticleController.Instance.blok();
            }
            else if (_blockob.CompareTag("blocksito2"))
            {
                ParticleController.Instance.blok2();   
            }

        }
        if (Input.GetKeyUp(_blockMove))
        {
            _blockFist.SetActive(false);
            if (_blockob.CompareTag("block"))
            {
                ParticleController.Instance.StopBlocking();
            }
            else if (_blockob.CompareTag("blocksito2"))
            {
                ParticleController.Instance.StopBlocking2();
            }
        }
        
    }
}
