using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoMoveState : PlayerBaseState
{
    public PlayerNoMoveState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.inputReader.DisableController();
        stateMachine.animator.Play("IDLE");
    }

    public override void InUpdate(float deltaTime)
    {
        
    }

    public override void OnExit()
    {
        stateMachine.inputReader.EnableController();
    }
}
