using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossSecondStageState : FirstBossBaseState
{
    public FirstBossSecondStageState(FirstBossStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
        stateMachine.attackManager.SetStage1Damage();
        stateMachine.animator.Play("BOSS|STAGE-2-INTRO");
        stateMachine.healthManager.healthLocked = true;
        stateMachine.healthManager.stage2Locked = true;
    }

    public override void InUpdate(float deltaTime)
    {
        StopChasing();
        FacePlayer();
        timer += deltaTime;

        if(timer>= stateMachine.healthManager.timeToShowSecondSword)
        {
            stateMachine.attackManager.EnableSecondWeapon();
        }

        if (timer >= stateMachine.healthManager.stage2Clip.length)
        {
            stateMachine.NextState(new FirstBossChasingState(stateMachine));
        }
    }

    public override void OnExit()
    {
        stateMachine.healthManager.healthLocked = false;
    }
}
