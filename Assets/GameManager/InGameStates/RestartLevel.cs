using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public GameObject _gameEndUi;
    public GameObject _nextGameButton;
    public void CurrentLevelRestart()
    {
       
        _nextGameButton.SetActive(true);
         ReloadCurrentScene();
    }
    public void ReloadCurrentScene()
    {
        
        GameManager.Instance._switch.SwitcCurrentState(SwitchStates.STATES.SELECTEDGAME);
        
    }
}
