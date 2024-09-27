using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    protected PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    Vector3 dir;
    public float shootTimer;
    public float attackTimer;

    #region MOVES
    protected void Move(float time)
    {
        dir = stateMachine.inputReader.direction;
        dir.Normalize();

        if(stateMachine.inputReader.isMoving)
        {
            RotateCharacter();
            stateMachine.characterController.Move(dir * stateMachine.speed * time);
            stateMachine.animator.Play("Walk");
        }

        else
        {
            stateMachine.animator.Play("Idle");
        }

    }

    protected void RotateCharacter()
    {
        Quaternion lookRot = Quaternion.LookRotation(dir, Vector3.up);
        Quaternion newLook = Quaternion.Euler(0, lookRot.y, 0);
        stateMachine.transform.rotation = lookRot;
    }

    protected void Aim(float time)
    {
        stateMachine.yValue += (stateMachine.inputReader.lookY * stateMachine.rotSpeed * 100) * time;
        float angle = stateMachine.yValue;
        Quaternion rot = Quaternion.Euler(0,angle,0);
        stateMachine.transform.rotation = rot;
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
        if(stateMachine.inputReader.controls.Player.ATTACK.WasPerformedThisFrame())
        {
            stateMachine.NextState(new PlayerAttackState(stateMachine));
        }
    }


    #endregion
}
