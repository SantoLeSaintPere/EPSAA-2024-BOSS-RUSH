
public class PlayerAimState : PlayerBaseState
{
    public PlayerAimState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.shootManager.EnableAimingPoint();
    }

    public override void InUpdate(float deltaTime)
    {
        stateMachine.animator.Play("Aim-Idle");

        Aim(deltaTime);

        if(stateMachine.inputReader.isShooting)
        {
            shootTimer += deltaTime;

            if (shootTimer >= stateMachine.shootManager.fireRate && stateMachine.shootManager.currentAmmo != 0)
            {
                stateMachine.shootManager.Shoot();
                shootTimer = 0;
            }
        }

        else
        {
            shootTimer = stateMachine.shootManager.fireRate;
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
