using System;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    public AttackS[] attacks;
    public GameObject axeObj;



    private void Start()
    {
        DisableAxe();
    }

    public void EnableAxe()
    {
        axeObj.SetActive(true);
    }

    public void DisableAxe()
    {
        axeObj.SetActive(false);
    }
}

[Serializable]
public class AttackS
{
    public string attackName;
    public AnimationClip attackClip;
    public float comboStart;
    public float comboEnd;
}
