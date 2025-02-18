using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : PlayerBaseState
{
    public PlayerDodgeState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.animator.Play("DASH");
        timer = 0;
        //stateMachine.characterController.excludeLayers = stateMachine.dashManager.enemyMask;
    }

    public override void InUpdate(float deltaTime)
    {
        if(stateMachine.groundManager.isGrounded)
        {
            DashMove();
        }

        timer += Time.deltaTime;

        if (timer >= stateMachine.dodgeManager.dodgeClip.length)
        {
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }

    }

    public override void OnExit()
    {
        stateMachine.dodgeManager.canDodge = false;
        //stateMachine.characterController.excludeLayers = default;
    }
}
