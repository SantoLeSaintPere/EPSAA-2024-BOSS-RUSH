using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossDeadState : FirstBossBaseState
{
    public FirstBossDeadState(FirstBossStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.animator.Play("BOSS|DEATH");
        stateMachine.healthManager.uiHolder.SetActive(false);

        if(stateMachine.audioManager != null)
        {
            stateMachine.audioManager.StopAll();
        }
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
    }

    public override void OnExit()
    {
    }
}
