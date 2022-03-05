using UnityEngine;
using UnityEngine.SceneManagement;
public class GUI : MonoBehaviour
{
    [SerializeField] private Canvas _canvasIU = default;
    [SerializeField] private GameObject lostPanel = default;
    void Start()
    {
        if (_canvasIU.enabled == true)
        {
            Time.timeScale = 0;
        }
    }

    [SerializeField] private void buttonPlay()
    {
        _canvasIU.enabled = false;
        Time.timeScale = 1;
    }

    public void buttonAgain()
    {
        SceneManager.LoadScene(0);
    }
}
