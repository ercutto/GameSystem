using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStateManager : MonoBehaviour
{
    SoundBase currentState;
    public NoSound noSound=new NoSound();
    public MenuSound menuSound=new MenuSound();
    public IntroSound introSound=new IntroSound();
    public LevelOneSound levelOne=new LevelOneSound();
    public AudioClip intro,menu,level;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        currentState = noSound;
        currentState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void  SwitcState(SoundBase state)
    {
        currentState = state;
        currentState.Enter(this);

    }
}
