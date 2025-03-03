using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMeleeAttackManager : MonoBehaviour
{
    [HideInInspector]
    public bool isPlayerInAttackRange;
    public float attackRange;
    public LayerMask playerMask;
    public int damage;
    public BossAttacks[] bossAttacks;
    //[HideInInspector]
    public int attackCounter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerMask);
    }

    public void Attack()
    {
        Collider [] hitPlayer = Physics.OverlapSphere(transform.position,attackRange, playerMask);
        foreach (Collider col in hitPlayer)
        {
            col.GetComponent<PlayerHealthManager>().TakeDamage(damage);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
