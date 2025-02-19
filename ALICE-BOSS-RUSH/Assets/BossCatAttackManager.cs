using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BossCatAttackManager : MonoBehaviour
{
    [HideInInspector]
    public bool isPlayerInAttackRange;
    public float attackRange;
    public LayerMask playerMask;
    public int damage;
    public BossAttacks[] bossAttacks;
    //[HideInInspector]
    public int attackCounter;

    [Header("SHOOT")]
    public float turnSpeed;
    public Transform holderSpawnPoint;
    Transform bulletPoint;
    public GameObject bulletToSpawn;
    public float bulletSpeed;
    public float timeToDestroy;

    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        bulletPoint = holderSpawnPoint.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerMask);
        FacePlayerWithSpeed();
    }

    protected void FacePlayerWithSpeed()
    {
        Vector3 playerPos = target.position;
        Vector3 pos = transform.position;

        Vector3 dir =  pos - playerPos;

        Quaternion rot = Quaternion.LookRotation(dir, Vector3.up);
        Quaternion newRot = Quaternion.Euler(0, rot.eulerAngles.y, 0);
        holderSpawnPoint.rotation = Quaternion.Slerp(holderSpawnPoint.rotation, newRot, (turnSpeed * 100) * Time.deltaTime);
    }
    public void Attack()
    {
        Collider[] hitPlayer = Physics.OverlapSphere(transform.position, attackRange, playerMask);
        foreach (Collider col in hitPlayer)
        {
            col.GetComponent<PlayerHealthManager>().TakeDamage(damage);
        }
    }


    public void Shoot()
    {
        GameObject bullet1 = Instantiate(bulletToSpawn, bulletPoint.position, bulletPoint.rotation);
        bullet1.GetComponent<Bullet>().damage = damage;
        bullet1.GetComponent<Bullet>().speed = bulletSpeed;
        bullet1.GetComponent<Bullet>().timeToDestroy = timeToDestroy;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}