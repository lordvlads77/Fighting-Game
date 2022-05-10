using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    [Header("Menu Panels")]
    [SerializeField] private GameObject _playScreen = default;
    [SerializeField] private Movement _movement = default;
    [SerializeField] private GameObject _settingsScreen = default;
    [SerializeField] private GameObject _keybindsScreen = default;
    [SerializeField] private GameObject _player1KeysPanel = default;
    [SerializeField] private GameObject _player2KeysPanel = default;
    [SerializeField] private AudioSource _lobbyMusic = default;
    [SerializeField] private AudioSource _battleMusic = default;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void ButtonPlay()
    {
        _playScreen.SetActive(false);
        _movement._screenPause.SetActive(false);
        Time.timeScale = 1;
        _lobbyMusic.enabled = false;
        _battleMusic.enabled = true;
    }

    public void ButtonAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        _playScreen.SetActive(false);
        _settingsScreen.SetActive(true);
    }

    public void Keybinds()
    {
        _settingsScreen.SetActive(false);
        _keybindsScreen.SetActive(true);
    }

    public void returnToStart()
    {
        _settingsScreen.SetActive(false);
        _playScreen.SetActive(true);
    }

    public void Player1Keybinds()
    {
        _keybindsScreen.SetActive(false);
        _player1KeysPanel.SetActive(true);
    }

    public void Player2Keybinds()
    {
        _keybindsScreen.SetActive(false);
        _player2KeysPanel.SetActive(true);
    }

    public void returnToSettings()
    {
        _keybindsScreen.SetActive(false);
        _settingsScreen.SetActive(true);
    }

    public void returnTokeybindsP1()
    {
        _player1KeysPanel.SetActive(false);
        _keybindsScreen.SetActive(true);
    }

    public void returnTokeybindsP2()
    {
        _player2KeysPanel.SetActive(false);
        _keybindsScreen.SetActive(true);
    }

    public void okeyReturntoHomeP1()
    {
        _player1KeysPanel.SetActive(false);
        _playScreen.SetActive(true);
    }

    public void okeyReturntoHomeP2()
    {
        _player2KeysPanel.SetActive(false);
        _playScreen.SetActive(true);
    }
}
