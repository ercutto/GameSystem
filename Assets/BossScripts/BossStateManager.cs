using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateManager : MonoBehaviour
{
    BossBase curentState;
    public BossIdle Idle=new BossIdle();
    public BossWalk Walk=new BossWalk();
    public BossAttack Attack=new BossAttack();
    public BossDied Died=new BossDied();
    // Start is called before the first frame update
    void Start()
    {
        curentState = Idle;
        curentState.Enter(this);      
    }

    // Update is called once per frame
    void Update()
    {
        curentState.UpdateState(this);
    }
    public void SwitchState(BossBase states)
    {
        curentState = states;
        curentState.Enter(this);
    }
}
