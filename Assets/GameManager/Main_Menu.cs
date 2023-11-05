using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    int openMenu = Animator.StringToHash("MainMenuOpen");
    int closeMenu = Animator.StringToHash("MainMenuClose");
    public Animator animator;
    public void EnterMainMenu()
    {
        GameManager.Instance.ChangeCanvasses(3, true);
        animator.Play(openMenu);
        Debug.Log("Main isPlaying");
    }
    public void ExitMainMenu()
    {
        StartCoroutine(AnimationEnd());
    }
    IEnumerator AnimationEnd()
    {

        animator.Play(closeMenu);

        yield return new WaitForSeconds(0.5f);
        Exit();

    }
    void Exit()
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
