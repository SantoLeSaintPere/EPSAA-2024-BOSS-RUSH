using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivator : MonoBehaviour
{
    public GameObject panel;
    public AnimationClip animationClip;
    bool on;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(on)
        {
            timer += Time.deltaTime;

            if(timer >= animationClip.length + 1)
            {
                panel.SetActive(false);
                on = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            on = true;
            panel.SetActive(true);
        }
    }
}
