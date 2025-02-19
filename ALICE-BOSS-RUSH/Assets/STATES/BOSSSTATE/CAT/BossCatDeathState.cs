using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCatDeathState : BossCatBaseState
{
    public BossCatDeathState(BossCatStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.animator.Play("DEATH");
        stateMachine.healthManager.uiHolder.SetActive(false);
        stateMachine.nextLevelLoader.isLocked = false;
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
    }

    public override void OnExit()
    {
    }
}
