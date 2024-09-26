using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEffectManager : MonoBehaviour
{
    public GameObject[] effects;
    public int count;
    public int maxCount;

    public float effectRate;
    // Start is called before the first frame update
    void Start()
    {
        HideALL();
        maxCount = effects.Length;
        StartCoroutine(AnimationCo());
    }

    // Update is called once per frame
    void Update()
    {
    }

    void HideALL()
    {
        foreach (GameObject effect in effects)
        {

            effect.SetActive(false);
        }

    }

    IEnumerator AnimationCo()
    {
        if (count != 0)
        {
            effects[count - 1].SetActive(false);
        }

        effects[count].SetActive(true);
        yield return new WaitForSeconds(effectRate);

        if (count == maxCount - 1)
        {
            HideALL();
            count = 0;
            StopAllCoroutines();
        }

        else
        {
            count++;
            StartCoroutine(AnimationCo());
        }

    }
}
