using UnityEngine;

public class PlayerDodgeManager : MonoBehaviour
{
    [HideInInspector]
    public Vector3 dodgeDir;
    //[HideInInspector]
    public bool canDodge;
    public float dodgeForce = 10;
    public AnimationClip dodgeClip;
    public float dodgeTimeRecovery = 0.25f;

    float timer;
    private void Start()
    {
        canDodge = true;
    }

    private void Update()
    {
        DashRecoveryCalculator();
    }

    private void DashRecoveryCalculator()
    {
        if (!canDodge)
        {

            timer += Time.deltaTime;

            if (timer >= dodgeTimeRecovery)
            {
                timer = 0;
                canDodge = true;
            }
        }
    }
}