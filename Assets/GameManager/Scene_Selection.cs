using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selection : MonoBehaviour
{
    int openMenu = Animator.StringToHash("SceneSelelctionOpen");
    int closeMenu = Animator.StringToHash("SceneSelectionClose");
    public Animator animator;
    int gameToPlay;
    
    
    public TMPro.TMP_Dropdown difficulty;
    int _difficulty;
    public void EnterSceneSelection()
    {
      
        GameManager.Instance.ChangeCanvasses(4, true);
        animator.Play(openMenu);
        Debug.Log("Scene_Selection isPlaying");
        
    }
    public void ExitSceneSelection()
    {
        GameManager.Instance.ChangeCanvasses(4, false);
        Debug.Log("Scene_Selection isEnded");
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.MAIN_CANVAS);
    }
    public void SelectScene(int sceneToLoad)
    {
        
            GameManager.Instance.ChangeCanvasses(4, false);
        
        
        Debug.Log("Scene_Selection isEnded");
        gameToPlay = sceneToLoad;
        
        SceneManager.LoadScene(gameToPlay);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.SELECTEDGAME);
        Debug.Log(_difficulty);
        
    }
    public void SelectDificulty()
    {
         _difficulty=difficulty.value;
        if (_difficulty == 0) { Debug.Log("easy"); }
        else if (_difficulty == 1) { Debug.Log("medium"); }
        else if (_difficulty == 2) { Debug.Log("Hard"); }
        

        
    }

    public bool ThereIsNextScene()
    {
        int _nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        
        if (_nextScene < SceneManager.sceneCountInBuildSettings) { return true; } else { return false; }
      
    }
    public bool SameUI()
    {
        return true;
    }
    public bool ThereIsPreviousScene()
    {
       
        int _previousScene = SceneManager.GetActiveScene().buildIndex - 1;

        if (_previousScene > SceneManager.GetSceneByBuildIndex(1).buildIndex) { return true; }else { return false; }       
    }
    //gelecek sahneyi playSelectedScene deki nex scenedenen iste!!!!
    public void NextScene()
    {
       
        int _nextScene=SceneManager.GetActiveScene().buildIndex+1;
       
        SceneManager.LoadScene(_nextScene);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.SELECTEDGAME);
    }
    public void LoadPreviousScene()
    {

        
        int _previousScene=SceneManager.GetActiveScene().buildIndex-1;

        
        SceneManager.LoadScene(_previousScene);
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.SELECTEDGAME);
    }
    public void LoadCurrentScene()
    {
        int _nextScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(_nextScene);
    }
    

}
