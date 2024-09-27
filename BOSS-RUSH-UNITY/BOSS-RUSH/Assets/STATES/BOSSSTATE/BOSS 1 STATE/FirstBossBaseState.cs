using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FirstBossBaseState : State
{
    protected FirstBossStateMachine stateMachine;

    protected FirstBossBaseState(FirstBossStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public float timer;
    public float timerAttack;
    public int attackNumber;

    protected void CheckHealth()
    {
        if(stateMachine.healthManager.isDead)
        {
            stateMachine.NextState(new FirstBossDeadState(stateMachine));
        }

        if(stateMachine.healthManager.stage2 && !stateMachine.healthManager.stage2Locked)
        {
            stateMachine.NextState(new FirstBossSecondStageState(stateMachine));
        }
    }
    protected void Chasing()
    {

        stateMachine.agent.isStopped = false;

        if(stateMachine.healthManager.stage2)
        {
            stateMachine.agent.speed = stateMachine.stage2Speed;
        }

        else
        {
            stateMachine.agent.speed = stateMachine.speed;
        }
        stateMachine.agent.angularSpeed = stateMachine.turnSpeed;
        stateMachine.agent.stoppingDistance = stateMachine.stoppingDistance;

        stateMachine.agent.SetDestination(stateMachine.player.position);
        stateMachine.animator.Play("BOSS|RUN");
    }

    protected void FacePlayer()
    {
        Vector3 playerPos = stateMachine.player.position;
        Vector3 pos = stateMachine.transform.position;

        Vector3 dir = playerPos - pos;

        Quaternion rot = Quaternion.LookRotation(dir, Vector3.up);
        Quaternion newRot = Quaternion.Euler(0, rot.eulerAngles.y, 0);
        stateMachine.transform.rotation = newRot;
    }

    protected void DefineAttack()
    {
        // HEALTH POURCETAGE
        if(stateMachine.healthManager.stage2)
        {

            attackNumber = Random.Range(3, 6);
        }

        else
        {
            attackNumber = Random.Range(0, 3);
        }
    }

    protected void AttackStage1(float deltaTime)
    {
        if(attackNumber == 0)
        {
            stateMachine.animator.Play("BOSS|ATTACK-1-VERTICAL");
        }


        if (attackNumber == 1)
        {
            stateMachine.animator.Play("BOSS|ATTACK-2-HORIZONTAL");
        }


        if (attackNumber == 2)
        {
            stateMachine.animator.Play("BOSS|ATTACK-3-STICK");
        }


        if (attackNumber == 3)
        {
            stateMachine.animator.Play("BOSS|ATTACK-4-CISOR-SLASH");
        }


        if (attackNumber == 4)
        {
            stateMachine.animator.Play("BOSS|ATTACK-5-VERTICAL");
        }


        if (attackNumber == 5)
        {
            stateMachine.animator.Play("BOSS|ATTACK-6-STICK");
        }


        timerAttack += deltaTime;

        if (timerAttack >= stateMachine.attackManager.bossAttacks[attackNumber].attackClip.length)
        {
            stateMachine.NextState(new FirstBossChasingState(stateMachine));
        }
    }


    protected void StopChasing()
    {
        stateMachine.agent.isStopped = true;
    }
}
