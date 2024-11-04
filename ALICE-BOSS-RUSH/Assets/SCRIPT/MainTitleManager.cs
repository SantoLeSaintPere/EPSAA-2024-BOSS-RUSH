using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainTitleManager : MonoBehaviour
{
    GameInputControls gameInputControls;

    VideoPlayer videoPlayer;
    AudioManager audioManager;
    public SceneField gameScene;
    public string ostToPlay;
    float timer;

    public Image holdButtonImg;
    public float holderTime = 2f;
    float buttonTimer;

    #region INPUT STUFF & GETCOMPONENT
    private void Awake()
    {
        gameInputControls = new GameInputControls();

        videoPlayer = GetComponent<VideoPlayer>();
        audioManager = FindAnyObjectByType<AudioManager>();


        videoPlayer.Play();

        audioManager.Play(ostToPlay);
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
        CheckVideoProgression();

        CheckPassButton();
    }

    private void CheckVideoProgression()
    {
        timer += Time.deltaTime;

        if (timer >= videoPlayer.clip.length)
        {
            SceneManager.LoadScene(gameScene);
        }
    }

    public void CheckPassButton()
    {
        if (gameInputControls.MENU.PASS.IsPressed())
        {
            buttonTimer += Time.deltaTime;
            if (buttonTimer >= holderTime)
            {
                SceneManager.LoadScene(gameScene);
            }
        }

        else
        {
            buttonTimer = 0;
        }

        holdButtonImg.fillAmount = buttonTimer / holderTime;
    }
}
