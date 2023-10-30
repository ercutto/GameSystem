
using UnityEngine;

public class BossDied : BossBase
{
    public override void Enter(BossStateManager boss)
    {
        Debug.Log("DiedState");
    }
    public override void UpdateState(BossStateManager boss)
    {
        Debug.Log("Boss Death");
        if (Input.GetKeyDown(KeyCode.Space)) { boss.SwitchState(boss.Idle); }

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
