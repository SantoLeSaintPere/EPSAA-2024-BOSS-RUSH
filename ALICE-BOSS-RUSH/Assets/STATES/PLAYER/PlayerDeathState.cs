using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathState : PlayerBaseState
{
    public PlayerDeathState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        int deathInt = stateMachine.healthManager.deathNumber;
        stateMachine.animator.Play("DEATH-" + deathInt);
    }

    public override void InUpdate(float deltaTime)
    {
        timer += Time.deltaTime;
        if (timer >= stateMachine.healthManager.timeToRestart )
        {
            stateMachine.gameManager.Reload();
        }
    }

    public override void OnExit()
    {
    }
}
