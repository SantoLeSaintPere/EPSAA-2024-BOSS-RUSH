using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController characterController;
    PlayerInputReader inputReader;
    PlayerGroundManager groundManager;

    public float speed = 5; 
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        inputReader = GetComponent<PlayerInputReader>();
        groundManager = GetComponent<PlayerGroundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputReader.isMoving)
        {
            Vector3 direction = new Vector3(inputReader.direction.x,0, inputReader.direction.y);
            groundManager.CheckGroundDetection();
            if(groundManager.isGrounded)
            {
                characterController.Move(direction * speed * Time.deltaTime);
            }
        }
    }
}
