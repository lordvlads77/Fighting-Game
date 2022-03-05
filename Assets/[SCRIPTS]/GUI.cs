using UnityEngine;

public class GUI : MonoBehaviour
{
    [SerializeField] private Canvas _canvasIU = default;
    void Start()
    {
        while (_canvasIU.enabled == true)
        {
            Time.timeScale = 0;
        }
    }
    
    void Update()
    {
        
    }

    void buttonPlay()
    {
        _canvasIU.enabled = false;
    }
}
