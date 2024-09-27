using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForcedRotation : MonoBehaviour
{
    Quaternion basedRot;
    // Start is called before the first frame update
    void Start()
    {
        basedRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = basedRot;
    }
}
