using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BossCakeBaseState : State
{
    protected BossCakeStateMachine stateMachine;

    protected BossCakeBaseState(BossCakeStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }


    public float timer;
    public float timerAttack;

    protected void CheckHealth()
    {
        if (stateMachine.healthManager.isDead)
        {
            stateMachine.NextState(new BossCakeDeathState(stateMachine));
        }

        if (stateMachine.healthManager.stage2 && !stateMachine.healthManager.stage2Locked)
        {
            stateMachine.NextState(new BossCakeStage2State(stateMachine));
        }
    }
    #region CHASING
    protected void Chasing()
    {

        stateMachine.agent.isStopped = false;

        if (stateMachine.healthManager.stage2)
        {
            stateMachine.agent.speed = stateMachine.stage2Speed;
        }

        else
        {
            stateMachine.agent.speed = stateMachine.speed;
        }
        stateMachine.agent.angularSpeed = stateMachine.angularSPeed;
        stateMachine.agent.stoppingDistance = stateMachine.stoppingDistance;

        stateMachine.agent.SetDestination(stateMachine.player.position);
    }
    protected void StopChasing()
    {
        stateMachine.agent.isStopped = true;
    }

    #endregion


    #region ATTACK

    protected void DefineAttack()
    {
        // HEALTH POURCETAGE
        if (stateMachine.healthManager.stage2)
        {

            stateMachine.attackManager.attackCounter = Random.Range(1, 2);
        }

        else
        {
            stateMachine.attackManager.attackCounter = 0;
        }
        int attackINT = stateMachine.attackManager.attackCounter + 1;
        stateMachine.animator.Play("ATTACK-" + attackINT);
    }


    protected void Attack(BossAttacks attacks)
    {


        timerAttack += Time.deltaTime;

        if (timerAttack >= attacks.attackClip.length)
        {
            stateMachine.NextState(new BossCakeChasingState(stateMachine));
        }
    }


    #endregion
}
