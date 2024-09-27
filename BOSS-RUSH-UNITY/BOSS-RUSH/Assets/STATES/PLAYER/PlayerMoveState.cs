
public class PlayerMoveState : PlayerBaseState
{
    public PlayerMoveState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate(float deltaTime)
    {
        Move(deltaTime);
        CheckForAim();
        CheckForAttack();
    }

    public override void OnExit()
    {
    }
}
