using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    public void EnterMainMenu()
    {
        GameManager.Instance.ChangeCanvasses(3, true);
        Debug.Log("Main isPlaying");
    }
    public void ExitMainMenu()
    {
        Debug.Log("Main_Menu isEnded");
        GameManager.Instance.ChangeCanvasses(3, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.SCENE_SELECTION);
    }
    public void EnterUserName()
    {

    }
    public void ScoreBoard()
    {

    }
    public void MusicSettings()
    {

    }
    public void Shop()
    {

    }
    public void DifficultySlect(int difficulty)
    {

    }

}
