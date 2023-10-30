
using UnityEngine;

public class BossWalk : BossBase
{
    public override void Enter(BossStateManager boss)
    {
        Debug.Log("Walking");
    }

    public override void UpdateState(BossStateManager boss)
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            boss.SwitchState(boss.Attack);
        }
      
    }

    public override void OnCollissionEnter(BossStateManager boss, Collision collision)
    {
        GameObject damage=collision.gameObject;
        if (damage.CompareTag("Player"))
        {
            boss.SwitchState(boss.Died);
        }
    }

   
}
