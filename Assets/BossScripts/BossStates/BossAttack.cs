
using UnityEngine;

public class BossAttack : BossBase
{
    public override void Enter(BossStateManager boss)
    {
        Debug.Log("AttackState");
    }
    public override void UpdateState(BossStateManager boss)
    {
        if(Input.GetKeyDown(KeyCode.Space)) { boss.SwitchState(boss.Died); }
    }
    public override void OnCollissionEnter(BossStateManager boss, Collision collision)
    {
        GameObject damage = collision.gameObject;
        if (damage.CompareTag("Player"))
        {
            boss.SwitchState(boss.Died);
        }
    }

  
}
