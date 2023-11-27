using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlaySelectedGame : MonoBehaviour
{
    public GameObject _gameAndUI;
   public void EnterSelectedGame()
    {
        if(_gameAndUI.activeInHierarchy) { _gameAndUI.SetActive(false); }

        GameManager.Instance.score=0;
        GameManager.Instance.ChangeCanvasses(5, true);
        Debug.Log("Game is Started");
        Instantiate(GameManager.Instance._dummyPlayer, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void ExitFromSelectedGame()
    {
        
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
            GameManager.Instance._scene_Slection.NextScene();
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
            GameManager.Instance._scene_Slection.LoadPreviousScene();
            //GameManager.Instance.ChangeCanvasses(5, false);
        }
        else
        {
            Debug.Log("There is not Previous Scene!");
        }
        

    }
}
