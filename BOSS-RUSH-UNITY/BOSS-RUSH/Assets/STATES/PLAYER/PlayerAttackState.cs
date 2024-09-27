
public class PlayerAttackState : PlayerBaseState
{
    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.animator.Play("Attack");
        attackTimer = 0;
    }

    public override void InUpdate(float deltaTime)
    {
        attackTimer += deltaTime;

        if(attackTimer >= stateMachine.attackManager.attacks[0].attackClip.length)
        {
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }
    }

    public override void OnExit()
    {
    }
}
