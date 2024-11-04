using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossChasingState : FirstBossBaseState
{
    public FirstBossChasingState(FirstBossStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate(float deltaTime)
    {
        CheckHealth();
        Chasing();

        if(stateMachine.attackManager.isPlayerInAttackRange)
        {
            stateMachine.NextState(new FirstBossAttackState(stateMachine));
        }
    }

    public override void OnExit()
    {
    }
}
