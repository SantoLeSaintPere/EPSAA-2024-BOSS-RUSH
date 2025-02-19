using System;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    PlayerShootManager shootManager;
    public int currentDamage = 1;

    [Header("SETTINGS")]
    public float yOffset = 0.5f;
    public float attackRange = 2;
    public LayerMask enemyMask;

    [Header("ANIMATIONS")]
    public PlayerAnimations[] attackAnimations;
    [HideInInspector]
    public int comboCounter,maxAttackCount;

    [HideInInspector]
    public bool isInComboWindow;
    // Start is called before the first frame update
    void Start()
    {
        shootManager = GetComponent<PlayerShootManager>();
        comboCounter = 0;
        maxAttackCount = attackAnimations.Length -1;
    }

    public void Attack()
    {

        Collider[] hitEnemies = Physics.OverlapSphere(transform.position + new Vector3(0,yOffset,0), attackRange, enemyMask);
        foreach (Collider collider in hitEnemies)
        {
            shootManager.RegainShoot();
            collider.GetComponent<BossHealthManager>().TakeDamage(currentDamage);
        }
    }
    private void OnDrawGizmos()
    {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position + new Vector3(0, yOffset, 0), attackRange);
    }
}

[Serializable]
public class PlayerAnimations
{
    public string attackName;
    public AnimationClip attackClip;
    public float comboTimeBegin;
    public float comboTimeEnd;
}
