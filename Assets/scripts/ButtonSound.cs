using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public void PlaySound()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlayButtonSound();
        }
    }
}