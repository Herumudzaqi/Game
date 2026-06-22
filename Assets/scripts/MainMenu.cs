using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelSetting;

    void Start()
    {
        panelSetting.SetActive(false);
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
        Debug.Log("Game Keluar");
    }
}