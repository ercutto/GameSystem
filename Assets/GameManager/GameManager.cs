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

    public bool accepted=false;


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
    
    




}
