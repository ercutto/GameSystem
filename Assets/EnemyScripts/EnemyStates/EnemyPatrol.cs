
using UnityEngine;

public class EnemyPatrol : EnemyBase
{
    public override void Enter(EnemyStateManager enemey)
    {
        Debug.Log("PatrolState");
    }
    public override void UpdateState(EnemyStateManager enemy)
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt)) { enemy.SwitchState(enemy.Attack); }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {

    }
}

   
