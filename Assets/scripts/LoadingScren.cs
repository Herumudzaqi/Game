using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingScreen : MonoBehaviour
{
    public Image loadingBar;
    public float loadingTime = 3f;

    IEnumerator Start()
    {
        float timer = 0f;

        while (timer < loadingTime)
        {
            timer += Time.deltaTime;
            loadingBar.fillAmount = timer / loadingTime;
            yield return null;
        }

        SceneManager.LoadScene("Main Menu");
    }
}