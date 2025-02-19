using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossQueenChasingState : BossQueenBaseState
{
    public BossQueenChasingState(BossQueenStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate(float deltaTime)
    {
        CheckHealth();

        if (stateMachine.healthManager.stage2)
        {
            stateMachine.animator.Play("STAGE-IDLE");
        }

        else
        {
            stateMachine.animator.Play("IDLE");
        }

        if (stateMachine.attackManager.isPlayerInAttackRange)
        {
            stateMachine.NextState(new BossQueenAttackState(stateMachine, stateMachine.attackManager.attackCounter));
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
