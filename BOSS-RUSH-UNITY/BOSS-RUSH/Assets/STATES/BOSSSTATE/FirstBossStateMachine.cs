using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FirstBossStateMachine : StateMachine
{
    [HideInInspector]
    public NavMeshAgent agent;
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public FirstBossAttackManager attackManager;
    [HideInInspector]
    public BossHealthManager healthManager;
    [HideInInspector]
    public AudioManager audioManager;

    public Animator animator;
    public float speed = 5f;
    public float stage2Speed = 7.5f;
    public float turnSpeed = 240f;
    public float stoppingDistance = 2f;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        attackManager = GetComponent<FirstBossAttackManager>();
        healthManager = GetComponent<BossHealthManager>();

        audioManager = FindObjectOfType<AudioManager>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }




    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, stoppingDistance);
    }

    public void ActiveBoss()
    {
        healthManager.healthLocked = false;
        NextState(new FirstBossChasingState(this));
    }
}
