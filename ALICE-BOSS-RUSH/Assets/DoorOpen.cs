using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float timer = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Invoke", timer);
    }

    public void Invoke()
    {
        gameObject.SetActive(false);
    }
}
