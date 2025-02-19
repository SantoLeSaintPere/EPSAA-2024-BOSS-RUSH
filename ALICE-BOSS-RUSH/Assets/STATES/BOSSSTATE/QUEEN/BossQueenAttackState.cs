using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossQueenAttackState : BossQueenBaseState
{
    BossAttacks attacks;

    public BossQueenAttackState(BossQueenStateMachine stateMachine, int count) : base(stateMachine)
    {
        attacks = stateMachine.attackManager.bossAttacks[count];
    }


    public override void InStart()
    {
        DefineAttack();
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
        CheckHealth();
        Attack(attacks);
    }

    public override void OnExit()
    {
    }
}
