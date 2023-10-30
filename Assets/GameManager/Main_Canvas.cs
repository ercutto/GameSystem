using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Canvas : MonoBehaviour
{
    public void EnterMainCanvas()
    {
        GameManager.Instance.ChangeCanvasses(2, true);
        Debug.Log("MainCanvas isPlaying");
    }
    public void ExitMainCanvas()
    {
        Debug.Log("MainCanvas isEnded");
        GameManager.Instance.ChangeCanvasses(2, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_MENU);
    }
}
