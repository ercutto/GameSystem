using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureStateMachine : MonoBehaviour
{
    NatureBas currentState;
    public DayState dayState=new DayState();
    public EveningState eveningState = new EveningState();
    public Material Day;
    public Material Night;
    // Start is called before the first frame update
    void Start()
    {
        currentState = dayState;
        currentState.Enter(this);
    }
    public void Update()
    {
        currentState.UpdateState(this);

    }
    public void TransitionState(NatureBas baseState)
    {
        currentState=baseState;
        currentState.Enter(this);
    }

   
}
