using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panelSetting;
    public GameObject panelLevel;

    public GameObject playButton;
    public GameObject settingButton;
    public GameObject quitButton;
    public GameObject logoGame;

    void Start()
    {
        panelSetting.SetActive(false);
        panelLevel.SetActive(false);
    }

    public void OpenLevel()
    {
        panelLevel.SetActive(true);

        playButton.SetActive(false);
        settingButton.SetActive(false);
        quitButton.SetActive(false);
        logoGame.SetActive(false);
    }

    public void CloseLevel()
    {
        panelLevel.SetActive(false);

        playButton.SetActive(true);
        settingButton.SetActive(true);
        quitButton.SetActive(true);
        logoGame.SetActive(true);
    }

    public void OpenSetting()
    {
        panelSetting.SetActive(true);
    }

    public void CloseSetting()
    {
        panelSetting.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}