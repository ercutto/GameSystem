using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{
    public string PrivacyLink;
    public Animator animator;
    int openMenu = Animator.StringToHash("privacyPolicyOpen");
    int closeMenu = Animator.StringToHash("PrivacyPolicyClose");
    public void DisplayPrivacyPolicy()
    {

        GameManager.Instance.ChangeCanvasses(0, true);
        animator.Play(openMenu);
        Debug.Log("PrivacyPoliciy Displayed");
    }
    public void ExitFromPrivacyPolicy()
    {
        GameManager.Instance.ChangeCanvasses(0, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.INTRO);
    }
    public void AcceptOrDecceline(bool _accepted)
    {
        GameManager.Instance.accepted = _accepted;
        if (_accepted)
        {
            animator.Play(closeMenu);
            StartCoroutine(AnimationEnd());
        }

    }
    public void ReadMore()
    {
        Application.OpenURL(PrivacyLink);
    }
    IEnumerator AnimationEnd()
    {


        yield return new WaitForSeconds(0.5f);
        ExitFromPrivacyPolicy();
       
    }

}
