using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrentGamePaused : MonoBehaviour
{
    public TMP_Text text;
    private string pause = "Pause";
    private string unPause = "Play";
    bool isPaused=false;
    public void Pause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            text.text = pause;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            isPaused=false;
            text.text = unPause;
        }
    }
}
