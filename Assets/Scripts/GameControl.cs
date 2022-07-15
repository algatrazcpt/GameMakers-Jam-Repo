using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject soundUi;
    void Start()
    {
        GameSoundStart();
    }
    void  GameSoundStart()
    {
        soundUi.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            soundUi.SetActive(true);
        }
    }
}
