
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
        stateMachine.groundDetector.CheckGroundDetection();
        Move(deltaTime);
        CheckForDash();
        CheckForAim();
        CheckForAttack();
    }

    public override void OnExit()
    {
    }
}
