
using UnityEngine;

public class EnemyIdle : EnemyBase
{
   

    public override void Enter(EnemyStateManager enemey)
    {
        Debug.Log("EnemyIdle");
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt)) { enemy.SwitchState(enemy.Patrol); }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
        
    }
}
