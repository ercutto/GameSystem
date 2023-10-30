
using UnityEngine;

public class EnemyAttack : EnemyBase
{
    

    public override void Enter(EnemyStateManager enemy)
    {
        Debug.Log("EnemyAttack");
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt)) { enemy.SwitchState(enemy.Death); }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {

    }
}
