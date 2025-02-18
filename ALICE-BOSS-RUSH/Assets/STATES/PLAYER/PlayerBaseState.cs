using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    protected PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    Vector3 direction;


    protected float timer;
    protected int counter;



    #region MOVES
    protected void Move(float time)
    {
        direction = new Vector3(stateMachine.inputReader.direction.x, 0, stateMachine.inputReader.direction.y);
        direction.Normalize();

        if(stateMachine.inputReader.isMoving && stateMachine.groundDetector.isGrounded)
        {
            stateMachine.characterController.Move(direction * stateMachine.speed * time);
            stateMachine.animator.Play("WALK");
        }

        else
        {
            stateMachine.animator.Play("IDLE");
        }

    }


    protected void Aim(float time)
    {
        stateMachine.yValue += (stateMachine.inputReader.lookY * stateMachine.rotSpeed * 100) * time;
        float angle = stateMachine.yValue;
        Quaternion rot = Quaternion.Euler(0,angle,0);
        stateMachine.transform.rotation = rot;
    }


    protected void DodgeMove()
    {
        if(stateMachine.groundDetector.isGrounded)
        {
            stateMachine.characterController.Move(stateMachine.dodgeManager.dodgeDir * stateMachine.dodgeManager.dodgeForce * Time.deltaTime);
        }
    }

    protected void ResetRot()
    {
        stateMachine.transform.rotation = Quaternion.Euler(0,0,0);
    }
    #endregion

    #region CHECKS

    protected void CheckForAim()
    {
        if(stateMachine.inputReader.isAiming)
        {
            stateMachine.NextState(new PlayerAimState(stateMachine));
        }
    }

    protected void CheckForAttack()
    {
        if(stateMachine.inputReader.inputControls.PLAYER.ATTACK.WasPerformedThisFrame())
        {
            stateMachine.NextState(new PlayerAttackState(stateMachine));
        }
    }


    protected void CheckForNextAttackCombo()
    {

        if (counter != stateMachine.attackManager.maxAttackCount)
        {
            if (timer >= stateMachine.attackManager.attackAnimations[counter].comboTimeBegin * stateMachine.fpsCalculator.oneFrameInSeconds)
            {
                stateMachine.attackManager.isInComboWindow = true;
                if (stateMachine.inputReader.inputControls.PLAYER.ATTACK.WasPerformedThisFrame())
                {
                    stateMachine.attackManager.comboCounter++;
                    stateMachine.NextState(new PlayerAttackState(stateMachine));
                }
            }

            if (timer >= stateMachine.attackManager.attackAnimations[counter].comboTimeEnd * stateMachine.fpsCalculator.oneFrameInSeconds)
            {
                stateMachine.attackManager.isInComboWindow = false;
            }
        }
    }


    protected void CheckForDash()
    {
        if (stateMachine.inputReader.inputControls.PLAYER.DASH.WasPerformedThisFrame() && stateMachine.dodgeManager.canDodge)
        {
            stateMachine.attackManager.comboCounter = 0;
            CalculateDashDir();
            stateMachine.NextState(new PlayerDodgeState(stateMachine));
        }
    }

    #endregion



    protected void CalculateDashDir()
    {
        if(direction == Vector3.zero)
        {
            direction = -stateMachine.transform.forward;
        }
        stateMachine.dodgeManager.dodgeDir = direction;
    }
}
