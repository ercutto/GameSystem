using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Canvas : MonoBehaviour
{
    int openMenu = Animator.StringToHash("MainCanvasOpen");
    int closeMenu = Animator.StringToHash("MainCanvasClose");
    public Animator animator;
    public void EnterMainCanvas()
    {
        GameManager.Instance.ChangeCanvasses(2, true);
        animator.Play(openMenu);
        Debug.Log("MainCanvas isPlaying");
    }
    public void ExitMainCanvas()
    {
        StartCoroutine(AnimationEnd());
    }
    IEnumerator AnimationEnd()
    {
        animator.Play(closeMenu);

        yield return new WaitForSeconds(0.5f);

        Debug.Log("intro isEnded");
        GameManager.Instance.ChangeCanvasses(2, false);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_MENU);

    }
}
