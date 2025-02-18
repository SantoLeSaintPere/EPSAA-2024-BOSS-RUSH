using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCakeStage2State : BossCakeBaseState
{
    public BossCakeStage2State(BossCakeStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.animator.Play("STAGE-2");
        stateMachine.healthManager.healthLocked = true;
        stateMachine.healthManager.stage2Locked = true;

    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
        timer += deltaTime;

        if (timer >= stateMachine.healthManager.stageTwoClip.length)
        {
            stateMachine.NextState(new BossCakeStage2State(stateMachine));
        }
    }

    public override void OnExit()
    {
        stateMachine.healthManager.healthLocked = false;
    }
}
