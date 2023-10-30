using UnityEngine;

public abstract class BossBase 
{
    public abstract void Enter(BossStateManager boss);
    public abstract void UpdateState(BossStateManager boss);
    public abstract void OnCollissionEnter(BossStateManager boss,Collision collision);

}
