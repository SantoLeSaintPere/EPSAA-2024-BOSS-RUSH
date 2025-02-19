using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCatChasingState : BossCatBaseState
{
    public BossCatChasingState(BossCatStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate(float deltaTime)
    {
        CheckHealth();
        
        stateMachine.animator.Play("IDLE");

        if (stateMachine.attackManager.isPlayerInAttackRange)
        {
            stateMachine.NextState(new BossCatAttackState(stateMachine, stateMachine.attackManager.attackCounter));
            return;
        }

        else
        {
            Chasing();
        }
    }

    public override void OnExit()
    {
    }
}
