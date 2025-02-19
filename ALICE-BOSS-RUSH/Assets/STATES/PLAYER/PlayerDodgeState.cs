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
        stateMachine.groundDetector.CheckDodgeDetection();
        stateMachine.animator.Play("DASH");
        timer = 0;
        stateMachine.characterController.excludeLayers = stateMachine.attackManager.enemyMask;
        stateMachine.healthManager.isInvicible = true;
    }

    public override void InUpdate(float deltaTime)
    {
        if(stateMachine.groundDetector.isGrounded)
        {
            DodgeMove();
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
        stateMachine.characterController.excludeLayers = default;
        stateMachine.healthManager.isInvicible = false;
    }
}
