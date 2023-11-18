using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get { if (_instance == null)
                Debug.Log("no game manager!");

            return _instance;

        }

    }
    public SwitchStates _switch;

    public PrivacyPolicy _privacyPolicy;
    public Intro _intro;
    public Main_Menu _main_Menu;
    public Scene_Selection _scene_Slection;
    public Main_Canvas _mainCanvas;
    public PlaySelectedGame _selectedGame;
    public GameObject _dummyPlayer;

    //inGameStates
    public CurrentGameIsPlaying _currentGameIsPlaying;
    public CurrentGamePaused _currentGamePaused;
    public CurrentMissionFailed _currentMissionFailed;
    public CurrentMissionIsComplated _currentMissionIsComplated;
    public ScoreBoardController _scoreBoardController;
    public NewLevelUnlocked _newLevelUnlocked;

    public bool accepted=false;
   
    public int score;
    public Canvas[] _canvases;
    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
        _switch.SwitcCurrentState(SwitchStates.STATES.PRIVACY_POLICY);

    }
    public void ChangeCanvasses(int canvas, bool TrueOrFlase)
    {
        _canvases[canvas].gameObject.SetActive(TrueOrFlase);
        
    }

    public void Update()
    {
       
       
    }
    public void GamePaused()
    {
        _currentGamePaused.Pause();
    }
    public void GameIsPlaying()
    {
        _currentGameIsPlaying.GameDynamics();
    }
    public void MissionComplated()
    {
        _currentMissionIsComplated.MissionComplated();
    }
    public void MissionFailed()
    {
        _currentMissionFailed.MissionFailed();
    }
    public void NewLevelUnlocked()
    {
        _newLevelUnlocked.UnLockLevel();
    }
    public void ScoreBoardUpdate()
    {
        _scoreBoardController.UpdateBoard();
    }
    
    




}
