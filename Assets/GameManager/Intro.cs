using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    int openMenu = Animator.StringToHash("IntroSceneOpen");
    int closeMenu = Animator.StringToHash("IntroSceneClose");
    public Animator animator;
    public void EnterIntro()
    {
        GameManager.Instance.ChangeCanvasses(1, true);
        animator.Play(openMenu);
        Debug.Log("intro isPlaying");
    }
    public void ExitIntro()
    {
        
        animator.Play(closeMenu);
        StartCoroutine(AnimationEnd());
      
    }
    IEnumerator AnimationEnd()
    {


        yield return new WaitForSeconds(0.5f);
        
        Debug.Log("intro isEnded");

        GameManager.Instance.ChangeCanvasses(1, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_CANVAS);
    }
   
}
