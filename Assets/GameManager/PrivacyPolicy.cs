using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{
    public string PrivacyLink;
    public  void DisplayPrivacyPolicy()
    {
        GameManager.Instance.ChangeCanvasses(0,true);
        Debug.Log("PrivacyPoliciy Displayed");
    }
    public void ExitFromPrivacyPolicy()
    {
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.INTRO);
    }
    public void AcceptOrDecceline(bool _accepted)
    {
        GameManager.Instance.accepted = _accepted;
        if (_accepted)
        {
            GameManager.Instance.ChangeCanvasses(0, false);
            GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.INTRO);
        }
            
    }
    public void ReadMore()
    {
        Application.OpenURL(PrivacyLink);
    }
    
}
