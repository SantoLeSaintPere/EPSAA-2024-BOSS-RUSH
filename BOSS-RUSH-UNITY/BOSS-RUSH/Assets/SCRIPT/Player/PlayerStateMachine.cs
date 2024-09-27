using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [HideInInspector]
    public CharacterController characterController;
    [HideInInspector]
    public PlayerInputReader inputReader;
    [HideInInspector]
    public PlayerShootManager shootManager;
    [HideInInspector]
    public PlayerAttackManager attackManager;

    public float speed = 5f;
    public float rotSpeed = 1f;
    [HideInInspector]
    public float yValue;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
        characterController = GetComponent<CharacterController>();
        shootManager = GetComponent<PlayerShootManager>();
        attackManager = GetComponent<PlayerAttackManager>();
        
        Invoke("Move", 0.1f);
    }

    public void Move()
    {

        NextState(new PlayerMoveState(this));
    }
}
