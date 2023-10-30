using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public void EnterIntro()
    {
        GameManager.Instance.ChangeCanvasses(1, true);
        Debug.Log("intro isPlaying");
    }
    public void ExitIntro()
    {
        Debug.Log("intro isEnded");
        GameManager.Instance.ChangeCanvasses(1, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_CANVAS);
    }
}
