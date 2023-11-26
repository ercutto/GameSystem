using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentMissionIsComplated : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameEndUI;
    [SerializeField]
    private GameObject nextLevelSprite;
    [SerializeField]
    private GameObject currentLevelSprite;
    [SerializeField] private GameObject nextLevelButton;
    public void MissionComplated()
    {
        _gameEndUI.SetActive(true);
        StartCoroutine(ShowNewLevel());
    }

    IEnumerator ShowNewLevel()
    {
        yield return new WaitForSeconds(1);
        currentLevelSprite.SetActive(false);
        yield return new WaitForSeconds(1);
        nextLevelSprite.SetActive(true);
        nextLevelButton.SetActive(true);
    }
}
