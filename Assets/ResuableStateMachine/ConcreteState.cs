using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteState : StateManager<ConcreteState.ConcreteStates>
{
    public enum ConcreteStates
    {
        DENEME,
        IKI,
        UC,
    }
    private void Awake()
    {
        currentState = States[ConcreteStates.DENEME];
    }
}
