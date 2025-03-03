using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTitleManager : MonoBehaviour
{
    GameInputControls gameInputControls;

    public SceneField gameScene;

    #region INPUT STUFF & GETCOMPONENT
    private void Awake()
    {
        gameInputControls = new GameInputControls();
    }

    private void OnEnable()
    {
        gameInputControls.MENU.Enable();
    }

    private void OnDisable()
    {
        gameInputControls.MENU.Disable();
    }
    #endregion

    void Update()
    {
        if (gameInputControls.MENU.PASS.IsPressed())
        {
            SceneManager.LoadScene(gameScene);
        }
    }
}
