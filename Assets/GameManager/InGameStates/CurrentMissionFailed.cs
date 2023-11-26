using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentMissionFailed : MonoBehaviour
{
    
    [SerializeField] private GameObject _gameEndUI;
    [SerializeField] private GameObject nextLevelButton;
    public void MissionFailed()
    {
        _gameEndUI.SetActive(true);
        nextLevelButton.SetActive(false);
    }
}
