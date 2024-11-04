using UnityEngine;

public class GunRotation : MonoBehaviour
{
    PlayerStateMachine stateMachine;
    PlayerInputReader inputReader;
    float yValue;

    public float yOffsetRot;
    Transform child;
    // Start is called before the first frame update
    void Start()
    {
        stateMachine = FindObjectOfType<PlayerStateMachine>();
        inputReader = stateMachine.GetComponent<PlayerInputReader>();

        child = transform.GetChild(0);
        child.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(inputReader.isAiming)
        {
            Aim();
            child.gameObject.SetActive(true);
        }

        else
        {
            child.gameObject.SetActive(false);
            /*
            Quaternion rot = Quaternion.Euler(0f, 0f, 0f);
            transform.rotation = rot;
            */
        }
    }




    protected void Aim()
    {
        yValue += (inputReader.lookY * stateMachine.rotSpeed * 100) *Time.deltaTime;
        float angle = stateMachine.yValue;
        Quaternion rot =  Quaternion.Euler(0, yOffsetRot + angle, 0);
        transform.rotation = rot;
    }
}
