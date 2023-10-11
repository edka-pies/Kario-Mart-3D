using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button playButton;
    [SerializeField] private UnityEngine.UI.Button optionsButton;
    [SerializeField] private UnityEngine.UI.Button exitButton;
    [SerializeField] private UnityEngine.UI.Button controlsButton;
    [SerializeField] private UnityEngine.UI.Button settingsButton;
    [SerializeField] private UnityEngine.UI.Button mainmenuButton;
    [SerializeField] private UnityEngine.UI.Button backButton;
    [SerializeField] private UnityEngine.UI.Button startButton;


    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject gameSelectorPanel;
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject settingsPanel;

    public void Start()
    {
        menuPanel.SetActive(true);
    }
    public void PlayButton()
    {
        menuPanel.gameObject.SetActive(false);
        gameSelectorPanel.gameObject.SetActive(true);
    }
    public void OptionsButton()
    {
        menuPanel.gameObject.SetActive(false);
        optionsPanel.gameObject.SetActive(true);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void ControlsButton()
    {
        gameSelectorPanel.gameObject.SetActive(false);
        menuPanel.gameObject.SetActive(true);
    }
    public void SettingsButton()
    {
        gameSelectorPanel.gameObject.SetActive(false);
        menuPanel.gameObject.SetActive(true);
    }
    public void MainmenuButton()
    {
        gameSelectorPanel.gameObject.SetActive(false);
        menuPanel.gameObject.SetActive(true);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

}
