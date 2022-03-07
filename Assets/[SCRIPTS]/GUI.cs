using UnityEngine;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    [SerializeField] private GameObject _playScreen = default;
    [SerializeField] private Movement _movement = default;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void ButtonPlay()
    {
        _playScreen.SetActive(false);
        _movement._ScreenPause.SetActive(false);
        Time.timeScale = 1;
    }

    public void ButtonAgain()
    {
        SceneManager.LoadScene(0);
    }
}
