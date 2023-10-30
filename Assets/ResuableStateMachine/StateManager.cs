using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public abstract class StateManager<EState>:MonoBehaviour where EState:Enum
{
    protected Dictionary<EState, BaseState<EState>> States = new Dictionary<EState, BaseState<EState>>();
    protected BaseState<EState> currentState;
    protected bool inTransitionState=false;
   
    void Start()
    {
        currentState.EnterState();
    }
    private void Update()
    {EState nextStateKey=currentState.GetNextState();

        if (!inTransitionState && nextStateKey.Equals(currentState.StateKey))
        {
            currentState.UpdateState();
        }
        else
        {
            TransitionToState(nextStateKey);
        }
    }
    public void TransitionToState(EState stateKey)
    {
        inTransitionState = true;
        currentState.ExitState();
        currentState=States[stateKey];
        currentState.EnterState();
        inTransitionState=false;
    }
    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(other);
    }
    private void OnTriggerExit(Collider other)
    {
        currentState.OnTriggerExit(other);
    }
    private void OnTriggerStay(Collider other)
    {
        currentState.OnTriggerStay(other);
    }
 

}
