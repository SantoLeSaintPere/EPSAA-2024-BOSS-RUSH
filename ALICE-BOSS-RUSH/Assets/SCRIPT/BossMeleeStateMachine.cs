using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMeleeStateMachine : MonoBehaviour
{
    public Animator animtor;

    public bool isInAttackRange;
    public float attackRange;
    public LayerMask playerMask;
    // Start is called before the first frame update
    void Start()
    {
        animtor = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerMask);

        if(isInAttackRange)
        {
            animtor.Play("ATTACK");
        }

        else
        {

            animtor.Play("IDLE");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
