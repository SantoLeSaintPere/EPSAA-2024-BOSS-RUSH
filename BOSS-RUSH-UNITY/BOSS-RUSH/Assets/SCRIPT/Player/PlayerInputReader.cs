using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour
{
    public Vector3 direction;
    public float lookY;

    public bool isMoving;
    public bool isAiming;


    public bool canUseInputs = true;

    public PlayerInputControls controls;

    private void Awake()
    {
        controls = new PlayerInputControls();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
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
            direction = new Vector3(controls.Player.MOVE.ReadValue<Vector2>().x,0, controls.Player.MOVE.ReadValue<Vector2>().y);
            isMoving = direction.magnitude > 0;

            isAiming = controls.Player.AIM.IsPressed();

            lookY = controls.Player.ROTATEY.ReadValue<float>();
        }
    }
}
