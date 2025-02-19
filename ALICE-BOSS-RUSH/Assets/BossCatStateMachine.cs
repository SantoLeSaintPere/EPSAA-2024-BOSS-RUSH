using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossCatStateMachine : StateMachine
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
    public BossCatAttackManager attackManager;
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

    public GameObject gun;
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        attackManager = GetComponent<BossCatAttackManager>();
        healthManager = GetComponent<BossHealthManager>();
        nextLevelLoader = FindObjectOfType<NextLevelLoader>();

        gun.SetActive(false);
        frameCalculator = FindObjectOfType<FramePerSecondCalculator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void ActiveBoss()
    {
        healthManager.healthLocked = false;
        NextState(new BossCatChasingState(this));
    }


    public void ActiveGun()
    {
        gun.SetActive(true);
        gameObject.SetActive(false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, stoppingDistance);
    }
}
