using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlaySelectedGame : MonoBehaviour
{
   public GameObject _gameAndUI;
   public GameObject _gamePlayUI;
   public Animator transitionAnimator;
   private int transition = Animator.StringToHash("Open");
    private GameObject _player;
   
    
   public void EnterSelectedGame()
    {
        if(_gameAndUI.activeInHierarchy) { _gameAndUI.SetActive(false);  }

        GameManager.Instance.score=0;
        GameManager.Instance.ChangeCanvasses(5, true);
        Debug.Log("Game is Started");
        _player = GameObject.FindGameObjectWithTag("Player");
        if(_player == null)
       { Instantiate(GameManager.Instance._dummyPlayer, new Vector3(0, 0, 0), Quaternion.identity); }
         
    }
    public void ExitFromSelectedGame()
    {
        PlayAnimation();
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_MENU);
        GameManager.Instance.ChangeCanvasses(5, false);

    }
    //gelecek sahneyi burdan cek!!!!
    public void NextScene()
    {
        if (GameManager.Instance._scene_Slection.ThereIsNextScene()&&GameManager.Instance._scene_Slection.SameUI())
        {
            Debug.Log(GameManager.Instance.score);

            GameManager.Instance.score = 0;
            StartCoroutine(TransitionForNextScene());
            
            //GameManager.Instance.ChangeCanvasses(5, false);
        }
        else
        {
            Debug.Log("There is not next Scene!");
        }


    }
    /// <summary>
    /// Gecmis Sahneyi buradan cek!!!
    /// </summary>
    public void BackToPreviousScene()
    {
        if(GameManager.Instance._scene_Slection.ThereIsPreviousScene()&&GameManager.Instance._scene_Slection.SameUI())
        {
            Debug.Log(GameManager.Instance.score);

            GameManager.Instance.score = 0;
            StartCoroutine(TransitionForPreviewScene());
            
            //GameManager.Instance.ChangeCanvasses(5, false);
        }
        else
        {
            Debug.Log("There is not Previous Scene!");
        }
        

    }
    #region Animation and Transitions
    public void PlayAnimation()
    {
        transitionAnimator.Play(transition);
    }

    IEnumerator TransitionForNextScene()
    {
        _gamePlayUI.SetActive(false);
        PlayAnimation();
        yield return new WaitForSeconds(0.5f);
        GameManager.Instance._scene_Slection.NextScene();
        yield return new WaitForSeconds(0.5f);
        _gamePlayUI.SetActive(true);

    }
    IEnumerator TransitionForPreviewScene()
    {
        _gamePlayUI.SetActive(false);
        PlayAnimation();
        yield return new WaitForSeconds(0.5f);
        GameManager.Instance._scene_Slection.LoadPreviousScene();
        yield return new WaitForSeconds(0.5f);
        _gamePlayUI.SetActive(true);

    }
    #endregion

}


