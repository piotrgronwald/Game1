using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject PausePanel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    // public void Mute()
    // {
    //     SetMusicOff
    // }

    // public void Vibration()
    // {
    //     SetVibrationOff
    // }
}
