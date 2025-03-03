using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    float health;
    public float maxHealth;
    public Image healthBar;
    public Image faceHealth;
    public Sprite[] Facesprites;

    PlayerStateMachine stateMachine;
    public float timeToRestart = 10;
    bool locked;

    [Range(1,3)]
    public int deathNumber = 1;
    [HideInInspector]
    public bool isInvicible;
    [Header("STUN SETTINGS")]
    public SpriteRenderer bodySprite;
    public float stunTimer;
    Color white, red;
    // Start is called before the first frame update
    void Start()
    {
        stateMachine = GetComponent<PlayerStateMachine>();
        ResetHealth();
        white = Color.white;
        red = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;

        if (health >= ((maxHealth *2) / 3) + 1)
        {
            faceHealth.sprite = Facesprites[0];
        }

        if (health <= ((maxHealth * 2) / 3) && health >= ((maxHealth * 1) / 3))
        {
            faceHealth.sprite = Facesprites[1];
        }

        if(health <= (maxHealth/3))
        {
            faceHealth.sprite = Facesprites[2];
        }

        if (health <= 0 && !locked)
        {
            stateMachine.NextState(new PlayerDeathState(stateMachine));
            locked = true;
        }


    }

    public void TakeDamage(int damage)
    {
        if (!isInvicible)
        {
            health -= damage;
            StartCoroutine(Stuntime());
        }
    }

    public void ResetHealth()
    {
        health = maxHealth;
    }


    IEnumerator Stuntime()
    {
        bodySprite.color = red;
        yield return new WaitForSeconds(stunTimer);
        bodySprite.color = white;
        StopAllCoroutines();
    }
}
