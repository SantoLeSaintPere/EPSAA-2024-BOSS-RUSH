using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTargetterManager : MonoBehaviour
{
    public GameObject targetter;
    // Start is called before the first frame update
    void Start()
    {
        DisableTargetter();
    }

    public void EnableTargetter()
    {
        targetter.SetActive(true);
    }

    public void DisableTargetter()
    {
        targetter.SetActive(false);
    }
}
