using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthManager : MonoBehaviour
{
    public Image healthBar;
    public GameObject uiHolder;
    float health;
    public float maxHealth;

    [HideInInspector]
    public bool isDead;
    [HideInInspector]
    public bool healthLocked;

    [HideInInspector]
    public bool stage2Locked;
    [HideInInspector]
    public bool stage2;

    [Header("STAGE 2")]
    [Range(2,3)]
    public int stageHealthDivider =3;

    public AnimationClip stageTwoClip;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;

        isDead = health <= 0;
        
        stage2 = health <= maxHealth / stageHealthDivider;


    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
