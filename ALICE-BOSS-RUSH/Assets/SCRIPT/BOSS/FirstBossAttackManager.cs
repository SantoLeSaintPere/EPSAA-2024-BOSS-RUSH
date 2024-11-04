using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossAttackManager : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange;
    public bool isPlayerInAttackRange;
    public LayerMask playerMask;
    public BossAttackAnimation[] bossAttacks;
    public GameObject[] weaponsHand;
    public GameObject backSword;

    [HideInInspector]
    public int currentDamage;
    public int[] damages;
    private void Start()
    {
        DisableSecondWeapon();
        DisableColliderWeapon();

    }
    private void Update()
    {
        isPlayerInAttackRange = Physics.Raycast(attackPoint.position, attackPoint.forward,attackRange,playerMask);
    }

    public void SetCurrentDamage()
    {
        currentDamage = damages[0];
    }


    public void SetStage1Damage()
    {
        currentDamage = damages[1];
    }

    public void EnableColliderWeapon()
    {
        foreach(GameObject weapon in weaponsHand)
        {
            weapon.GetComponent<Collider>().enabled = true;
        }
    }


    public void DisableColliderWeapon()
    {
        foreach (GameObject weapon in weaponsHand)
        {
            weapon.GetComponent<Collider>().enabled = false;
        }
    }

    public void DisableSecondWeapon()
    {
        weaponsHand[1].SetActive(false);
    }

    public void EnableSecondWeapon()
    {
        weaponsHand[1].SetActive(true);
        backSword.SetActive(false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 dir = attackPoint.forward * attackRange;
        Debug.DrawRay(attackPoint.position, dir);
    }
}

[Serializable]
public class BossAttackAnimation
{

    public AnimationClip attackClip;
    public float timeToEnableWeapon;
    public float timeToDisavleWeapon;
}
