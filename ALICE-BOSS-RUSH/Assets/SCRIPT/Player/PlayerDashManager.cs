using UnityEngine;

public class PlayerDashManager : MonoBehaviour
{
    [HideInInspector]
    public Vector3 dashDir;
    [HideInInspector]
    public bool canDash;
    public float dashSpeed = 30;
    public float dashTimerLimit = 0.25f;
    public float dashTimeRecovery = 0.25f;
    public LayerMask enemyMask;

    float timer;
    private void Start()
    {
        canDash = true;
    }

    private void Update()
    {
        DashRecoveryCalculator();
    }

    private void DashRecoveryCalculator()
    {
        if (!canDash)
        {
            timer += Time.deltaTime;

            if (timer >= dashTimeRecovery)
            {
                timer = 0;
                canDash = true;
            }
        }
    }
}