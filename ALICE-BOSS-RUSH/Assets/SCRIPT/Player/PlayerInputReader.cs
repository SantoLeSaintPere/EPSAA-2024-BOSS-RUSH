using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour
{
    public Vector2 direction;
    public float lookY;

    public bool isMoving;
    public bool isAiming;
    public bool isShooting;

    public bool canUseInputs = true;

    public GameInputControls inputControls;

    private void Awake()
    {
        inputControls = new GameInputControls();
        EnableController();
    }

    public void EnableController()
    {
        inputControls.PLAYER.Enable();
    }

    public void DisableController()
    {
        inputControls.PLAYER.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canUseInputs)
        {
            direction = inputControls.PLAYER.MOVE.ReadValue<Vector2>();
            isMoving = direction.magnitude > 0;

            isAiming = inputControls.PLAYER.AIM.IsPressed();

            lookY = inputControls.PLAYER.ROTATEY.ReadValue<float>();

            isShooting = inputControls.PLAYER.SHOOT.IsPressed();
        }
    }
}
