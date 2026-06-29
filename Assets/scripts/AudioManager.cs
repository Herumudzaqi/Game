using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Sound Effects")]
    [SerializeField] private AudioClip buttonClick;

    private bool musicOn;
    private bool sfxOn;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        musicOn = PlayerPrefs.GetInt("Music", 1) == 1;
        sfxOn = PlayerPrefs.GetInt("SFX", 1) == 1;

        UpdateAudio();
    }

    private void UpdateAudio()
    {
        if (musicSource != null)
            musicSource.mute = !musicOn;

        if (sfxSource != null)
            sfxSource.mute = !sfxOn;
    }

    public void ToggleMusic()
    {
        musicOn = !musicOn;

        PlayerPrefs.SetInt("Music", musicOn ? 1 : 0);
        PlayerPrefs.Save();

        UpdateAudio();
    }

    public void ToggleSFX()
    {
        sfxOn = !sfxOn;

        PlayerPrefs.SetInt("SFX", sfxOn ? 1 : 0);
        PlayerPrefs.Save();

        UpdateAudio();
    }

    public void PlayButtonSound()
    {
        if (sfxOn && buttonClick != null)
        {
            sfxSource.PlayOneShot(buttonClick);
        }
    }

    public bool IsMusicOn()
    {
        return musicOn;
    }

    public bool IsSfxOn()
    {
        return sfxOn;
    }
}