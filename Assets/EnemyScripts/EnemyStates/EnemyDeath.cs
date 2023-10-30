using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : EnemyBase
{
    public override void Enter(EnemyStateManager enemey)
    {
        Debug.Log("EnemyDeath");
    }
    public override void UpdateState(EnemyStateManager enemy)
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt)) { enemy.SwitchState(enemy.Idle); }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
       
    }

   
}
