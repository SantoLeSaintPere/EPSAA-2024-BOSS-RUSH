using System;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    [HideInInspector]
    public int currentDamage;

    [Header("ANIMATIONS")]
    public PlayerAnimations[] attackAnimations;
    public int comboCounter;
    public int maxAttackCount;

    [HideInInspector]
    public bool isInComboWindow;

    // Start is called before the first frame update
    void Start()
    {
        comboCounter = 0;
        maxAttackCount = attackAnimations.Length;
    }


}

[Serializable]
public class PlayerAnimations
{
    public string attackName;
    public AnimationClip attackClip;
    public float comboTimeBegin;
    public float comboTimeEnd;
    public int damage = 1;
}
