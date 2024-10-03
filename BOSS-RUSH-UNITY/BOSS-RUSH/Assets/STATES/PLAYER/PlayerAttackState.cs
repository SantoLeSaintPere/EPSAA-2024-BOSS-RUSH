

public class PlayerAttackState : PlayerBaseState
{
    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void InStart()
    {
        counter = stateMachine.attackManager.comboCounter;
        timer = 0;

        stateMachine.animator.Play(stateMachine.attackManager.attackAnimations[counter].attackName);

    }

    public override void InUpdate(float deltaTime)
    {
        CheckForDash();
        CheckForNextAttackCombo();
        timer += deltaTime;
        //IN CASE NO COMBO COMPLETED
        if (timer >= stateMachine.attackManager.attackAnimations[0].attackClip.length)
        {
            stateMachine.attackManager.comboCounter = 0;
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }
    }

    public override void OnExit()
    {
        stateMachine.attackManager.isInComboWindow = false;
    }
}
