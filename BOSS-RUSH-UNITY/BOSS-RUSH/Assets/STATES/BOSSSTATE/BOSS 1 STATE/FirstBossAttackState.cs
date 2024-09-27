using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossAttackState : FirstBossBaseState
{
    public FirstBossAttackState(FirstBossStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        DefineAttack();
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
        CheckHealth();
        AttackStage1(deltaTime);
    }

    public override void OnExit()
    {
        stateMachine.attackManager.DisableColliderWeapon();
    }
}
