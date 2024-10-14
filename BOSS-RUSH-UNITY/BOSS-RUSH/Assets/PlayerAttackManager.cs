using System;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    [HideInInspector]
    public int currentDamage;

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
        comboCounter = 0;
        maxAttackCount = attackAnimations.Length -1;
    }

    public void Attack()
    {
        currentDamage = attackAnimations[comboCounter].damage;

        Collider[] hitEnemies = Physics.OverlapSphere(transform.position + new Vector3(0,yOffset,0), attackRange, enemyMask);
        foreach (Collider collider in hitEnemies)
        {
            //collider.GetComponent<EnemyHealthManager>().TakeDamage(currentDamage);
        }
    }
    private void OnDrawGizmosSelected()
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
    public int damage = 1;
}
