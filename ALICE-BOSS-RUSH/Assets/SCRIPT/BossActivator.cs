using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BossActivator : MonoBehaviour
{
    public UnityEvent activeBoss;
    public GameObject panel;
    public GameObject bossUi;
    public AnimationClip animationClip;
    bool locked;
    // Start is called before the first frame update
    void Start()
    {
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
        activeBoss.Invoke();
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !locked)
        {
            panel.SetActive(true);
            Invoke("Delay", animationClip.length);
            locked = true;
        }
    }
}
