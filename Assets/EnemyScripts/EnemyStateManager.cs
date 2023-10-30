
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    EnemyBase currentState;
    public EnemyAttack Attack=new EnemyAttack();
    public EnemyIdle Idle = new EnemyIdle();
    public EnemyPatrol Patrol = new EnemyPatrol();
    public EnemyDeath Death = new EnemyDeath();
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = Idle;
        currentState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
        
    }
    public void SwitchState(EnemyBase state)
    {
        currentState=state;
        currentState.Enter(this);
    }
}
