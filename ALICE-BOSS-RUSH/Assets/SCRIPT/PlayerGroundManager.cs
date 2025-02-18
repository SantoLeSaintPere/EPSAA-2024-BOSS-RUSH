using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundManager : MonoBehaviour
{
    PlayerDodgeManager dodgeManager;
    PlayerInputReader inputReader;
    public Transform groundDetectorHolder;
    public Transform groundDetector;
    public float range = 2f;
    public LayerMask groundLayer;
    //[HideInInspector]
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
        dodgeManager = GetComponent<PlayerDodgeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(groundDetector.position, -groundDetector.up, range, groundLayer);


    }

    public void CheckGroundDetection()
    {
        if (inputReader.isMoving)
        {
            Vector3 dir = new Vector3(inputReader.direction.x, 0, inputReader.direction.y);
            Quaternion lookRot = Quaternion.LookRotation(dir, Vector3.up);
            groundDetectorHolder.localRotation = lookRot;
        }
    }

    public void CheckDodgeDetection()
    {

        Quaternion lookRot = Quaternion.LookRotation(dodgeManager.dodgeDir, Vector3.up);
        groundDetectorHolder.localRotation = lookRot;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Debug.DrawRay(groundDetector.position, -groundDetector.up * range);
    }

}