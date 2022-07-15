using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUi : MonoBehaviour
{
    public string gameSceneName = "";
    public string settingsSceneName = "";
    public GameObject gameUi;
    public GameObject soundUi;
    
    private void Start()
    {
        soundUi.gameObject.SetActive(false);

    }
    public void NewGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void SettingsMenu()
    {
        soundUi.gameObject.SetActive(true);
        gameUi.gameObject.SetActive(false);
    }
    public void BackGame()
    {
        soundUi.gameObject.SetActive(false);
        gameUi.gameObject.SetActive(true);
    }
}
