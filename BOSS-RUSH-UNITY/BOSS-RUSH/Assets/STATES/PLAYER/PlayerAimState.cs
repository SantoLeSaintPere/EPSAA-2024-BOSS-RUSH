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
        stateMachine.aimManager.EnableAimingPoint();
    }

    public override void InUpdate(float deltaTime)
    {
        Aim(deltaTime);
        if(!stateMachine.inputReader.isAiming)
        {
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }
    }

    public override void OnExit()
    {
        stateMachine.aimManager.DisableAimingPoint();
    }
}
