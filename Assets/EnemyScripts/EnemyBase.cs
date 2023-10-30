
using UnityEngine;

public abstract class EnemyBase
{
    public abstract void Enter(EnemyStateManager enemey);
    public abstract void UpdateState(EnemyStateManager enemy);
    public abstract void OnCollisionEnter(EnemyStateManager enemy);
}
