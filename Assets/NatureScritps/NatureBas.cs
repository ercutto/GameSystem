
using UnityEngine;

public abstract class NatureBas 
{
    
    public abstract void Enter(NatureStateMachine nature);
    public abstract void UpdateState(NatureStateMachine nature);
    public abstract void TransitonState(NatureStateMachine nature);
    
}
