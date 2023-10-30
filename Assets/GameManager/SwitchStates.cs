
using UnityEngine;

public class SwitchStates:MonoBehaviour 
{
    public enum STATES
    {
        PRIVACY_POLICY,
        INTRO,
        MAIN_CANVAS,
        MAIN_MENU,
        SCENE_SELECTION,
        SELECTEDGAME,
       


    }
    public void  SwitcCurrentState(STATES state)
    {
      switch(state)
        {
            case STATES.PRIVACY_POLICY:
     
                GameManager.Instance._privacyPolicy.DisplayPrivacyPolicy();
                
                break;
            case STATES.INTRO:
     
                GameManager.Instance._intro.EnterIntro();
               
                break;
            case STATES.MAIN_CANVAS:
            
                GameManager.Instance._mainCanvas.EnterMainCanvas();
               
                break;
            case STATES.MAIN_MENU:
       
                GameManager.Instance._main_Menu.EnterMainMenu();
               
                break;
            case STATES.SCENE_SELECTION:
               
                GameManager.Instance._scene_Slection.EnterSceneSelection();
                break;
            case STATES.SELECTEDGAME:
                GameManager.Instance._selectedGame.EnterSelectedGame();
                break;
            

        }
    }

    
}
