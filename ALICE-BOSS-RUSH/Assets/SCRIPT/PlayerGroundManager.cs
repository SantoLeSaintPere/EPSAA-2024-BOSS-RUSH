using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundManager : MonoBehaviour
{
    PlayerInputReader inputReader;
    public float radius;
    public LayerMask groundMask;
    public Transform groundDetectorHolder;
    Transform groundDetector;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        groundDetector = groundDetectorHolder.GetChild(0);
        inputReader = FindObjectOfType<PlayerInputReader>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateGroundDetector();
        isGrounded = Physics.CheckSphere(groundDetector.position, radius, groundMask);
    }

    public void RotateGroundDetector()
    {
        if(inputReader.isMoving)
        {
            Quaternion lookRot = Quaternion.LookRotation(inputReader.direction, Vector3.up);
            Quaternion newLook = Quaternion.Euler(0, lookRot.y, 0);
            groundDetectorHolder.rotation = lookRot;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(groundDetector != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(groundDetector.position, radius);
        }
    }
}
