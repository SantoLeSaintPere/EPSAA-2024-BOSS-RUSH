using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        Aim(deltaTime);

        if(stateMachine.inputReader.isShooting)
        {
            shootTimer += deltaTime;
        }

        else
        {
            shootTimer = 0;
        }
        
        if(shootTimer >= stateMachine.shootManager.timeToShoot && stateMachine.shootManager.currentAmmo !=0)
        {
            stateMachine.shootManager.Shoot();
            shootTimer = 0;
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
