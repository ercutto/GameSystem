using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMunu : MonoBehaviour
{ 
    public Animator miniMenuAnimatorContrroller;
    private bool isClicked=false;
    int openMenu=Animator.StringToHash("menuOpen");
    int closeMenu = Animator.StringToHash("menuClose");

    public void OpenMiniMenu()
    {
        if (isClicked) { return; }
        else
        {
            miniMenuAnimatorContrroller.Play(openMenu);

            Invoke(nameof(IsClicked), 1);
        }
        

    }
    void IsClicked()
    {
        isClicked = true;
    }
    public void CloseMiniMenu()
    {
        if (isClicked)
        {
            miniMenuAnimatorContrroller.Play(closeMenu);
            isClicked = false;
        }
    }
   
}
