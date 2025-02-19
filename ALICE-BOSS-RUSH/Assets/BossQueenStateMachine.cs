using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossQueenStateMachine : StateMachine
{
    [HideInInspector]
    public NavMeshAgent agent;
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public Animator animator;
    [HideInInspector]
    public FramePerSecondCalculator frameCalculator;
    [HideInInspector]
    public BossMeleeAttackManager attackManager;
    [HideInInspector]
    public BossHealthManager healthManager;

    [Header("SPEED")]
    public float speed = 5f;
    public float stage2Speed = 7.5f;
    [Header("TURN SPEED")]
    public float turnSpeed = 5f;

    [Header("NAV MESH AGENT SETTINGS")]
    public float stoppingDistance = 2f;
    [HideInInspector]
    public NextLevelLoader nextLevelLoader;

    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        attackManager = GetComponent<BossMeleeAttackManager>();
        healthManager = GetComponent<BossHealthManager>();
        nextLevelLoader = FindObjectOfType<NextLevelLoader>();
    }

    public void ActiveBoss()
    {
        healthManager.healthLocked = false;
        frameCalculator = FindObjectOfType<FramePerSecondCalculator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        NextState(new BossQueenChasingState(this));
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, stoppingDistance);
    }
}
