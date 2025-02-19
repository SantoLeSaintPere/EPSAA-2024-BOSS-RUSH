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


    [Header("STUN SETTINGS")]
    public SpriteRenderer bodySprite;
    public float stunTimer;
    Color white, red;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthLocked = true;
        white = Color.white;
        red = Color.red;
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
        StartCoroutine(Stuntime());
    }


    IEnumerator Stuntime()
    {
        bodySprite.color = red;
        yield return new WaitForSeconds(stunTimer);
        bodySprite.color = white;
        StopAllCoroutines();
    }
}
