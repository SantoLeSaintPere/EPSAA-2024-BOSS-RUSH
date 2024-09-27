using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
