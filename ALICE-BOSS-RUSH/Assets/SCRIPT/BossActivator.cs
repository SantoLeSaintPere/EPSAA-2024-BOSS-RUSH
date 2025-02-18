using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BossActivator : MonoBehaviour
{
    PlayerStateMachine playerStateMachine;
    public UnityEvent activeBoss;
    public GameObject panel;
    public GameObject bossUi;
    public AnimationClip animationClip;
    bool locked;
    // Start is called before the first frame update
    void Start()
    {
        playerStateMachine = FindObjectOfType<PlayerStateMachine>();

        panel.SetActive(false);
        bossUi.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Delay()
    {
        panel.SetActive(false);
        bossUi.SetActive(true);
        playerStateMachine.NextState(new PlayerMoveState(playerStateMachine));
        activeBoss.Invoke();
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !locked)
        {
            playerStateMachine.NextState(new PlayerNoMoveState(playerStateMachine));
            panel.SetActive(true);
            Invoke("Delay", animationClip.length);
            locked = true;
        }
    }
}
