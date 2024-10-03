
public class PlayerAimState : PlayerBaseState
{
    public PlayerAimState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.shootManager.EnableAimingPoint();
        timer = 0;
    }

    public override void InUpdate(float deltaTime)
    {
        stateMachine.animator.Play("AIM-IDLE");

        Aim(deltaTime);

        if(stateMachine.inputReader.isShooting)
        {
            timer += deltaTime;

            if (timer >= stateMachine.shootManager.fireRate && stateMachine.shootManager.currentAmmo != 0)
            {
                stateMachine.shootManager.Shoot();
                timer = 0;
            }
        }

        else
        {
            timer = stateMachine.shootManager.fireRate;
        }
        

        if(!stateMachine.inputReader.isAiming)
        {
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }
    }

    public override void OnExit()
    {
        stateMachine.shootManager.DisableAimingPoint();
    }
}
