using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimManager : MonoBehaviour
{
    public GameObject aimingPoint;
    // Start is called before the first frame update
    void Start()
    {
        DisableAimingPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableAimingPoint()
    {
        aimingPoint.SetActive(true);
    }

    public void DisableAimingPoint()
    {
        aimingPoint.SetActive(false);
    }
}
