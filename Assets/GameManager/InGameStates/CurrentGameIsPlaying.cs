using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentGameIsPlaying : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameEndUI;
    public void GameDynamics()
    {
        _gameEndUI.SetActive(false);
    }
}
