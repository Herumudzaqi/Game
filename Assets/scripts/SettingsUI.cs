using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [Header("Music")]
    public Button musicButton;
    public Image musicImage;
    public TMP_Text musicStatus;

    [Header("Audio")]
    public Button audioButton;
    public Image audioImage;
    public TMP_Text audioStatus;

    [Header("Sprite")]
    public Sprite speakerOn;
    public Sprite speakerOff;

    void Start()
    {
        musicButton.onClick.AddListener(ToggleMusic);
        audioButton.onClick.AddListener(ToggleAudio);

        RefreshUI();
    }

    void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
        RefreshUI();
    }

    void ToggleAudio()
    {
        AudioManager.Instance.ToggleSFX();
        RefreshUI();
    }

    void RefreshUI()
    {
        bool music = AudioManager.Instance.IsMusicOn();
        bool audio = AudioManager.Instance.IsSfxOn();

        musicImage.sprite = music ? speakerOn : speakerOff;
        musicStatus.text = music ? "ON" : "OFF";

        audioImage.sprite = audio ? speakerOn : speakerOff;
        audioStatus.text = audio ? "ON" : "OFF";
    }
}