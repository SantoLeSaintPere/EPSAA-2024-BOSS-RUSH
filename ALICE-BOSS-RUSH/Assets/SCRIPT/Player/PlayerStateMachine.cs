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
    [HideInInspector]
    public PlayerDodgeManager dodgeManager;
    [HideInInspector]
    public PlayerGroundManager groundDetector;
    [HideInInspector]
    public PlayerHealthManager healthManager;
    [HideInInspector]
    public FramePerSecondCalculator fpsCalculator;

    public float speed = 5f;
    public float rotSpeed = 1f;
    [HideInInspector]
    public float yValue;
    [HideInInspector]
    public Animator animator;
    [HideInInspector]
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
        characterController = GetComponent<CharacterController>();
        shootManager = GetComponent<PlayerShootManager>();
        attackManager = GetComponent<PlayerAttackManager>();
        dodgeManager = GetComponent<PlayerDodgeManager>();
        groundDetector = GetComponent<PlayerGroundManager>();
        healthManager = GetComponent<PlayerHealthManager>();
        fpsCalculator = FindObjectOfType<FramePerSecondCalculator>();

        animator = GetComponentInChildren<Animator>();

        gameManager = FindObjectOfType<GameManager>();
        Invoke("Move", 0.1f);
    }

    public void Move()
    {

        NextState(new PlayerMoveState(this));
    }
}
