using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCakeDeathState : BossCakeBaseState
{
    public BossCakeDeathState(BossCakeStateMachine stateMachine) : base(stateMachine)
    {
    }


    public override void InStart()
    {
        stateMachine.animator.Play("DEATH");
        stateMachine.healthManager.uiHolder.SetActive(false);
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
    }

    public override void OnExit()
    {
    }
}
