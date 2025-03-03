using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameInputControls inputcontrols;
    PlayerInputReader inputReader;
    AudioManager audiomanager;
    PauseMenuManager pausemanager;
    CursorManager cursormanager;
    //SaveManager savemanager;

    public static bool onPause;
    public SceneField mainMenu;
    private void Awake()
    {
        inputcontrols = new GameInputControls();
    }

    private void OnEnable()
    {
        inputcontrols.GAMEMANAGER.Enable();
    }

    private void OnDisable()
    {
        inputcontrols.GAMEMANAGER.Disable();
    }

    private void Start()
    {
        audiomanager = FindObjectOfType<AudioManager>();
        inputReader = FindObjectOfType<PlayerInputReader>();
        pausemanager = GetComponent<PauseMenuManager>();
        cursormanager = GetComponent<CursorManager>();

        //savemanager = GetComponent<SaveManager>();
    }
    // Update is called once per frame
    void Update()
    {
        CheckPause();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    private void CheckPause()
    {
        if (inputcontrols.GAMEMANAGER.QUIT.WasPerformedThisFrame())
        {
            //Quit();
            
            if (!onPause)
            {
                Pause();
            }

            else
            {
                Resume();
            }
        }
    }

    public void Quit()
    {
        Application.Quit();

    }

    public void Reload()
    {
        if (audiomanager != null)
        {
            audiomanager.StopAll();
        }

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        onPause = true;
        inputReader.DisableController();
        cursormanager.isCursorNeeded = true;
        pausemanager.Pause();
    }

    public void Resume()
    {
        //savemanager.settingsDataManager.SaveData();
        onPause = false;
        inputReader.EnableController();
        cursormanager.isCursorNeeded = false;
        pausemanager.Resume();
    }
}
