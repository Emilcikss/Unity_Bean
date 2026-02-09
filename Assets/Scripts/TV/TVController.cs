using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TVController : MonoBehaviour
{
    [Header("Channels (0 = Black/off, 1..3 = real channels)")]
    [SerializeField] private GameObject[] channels; // size 4: 0..3
    [SerializeField] private int startChannel = 1;

    [Header("UI")]
    [SerializeField] private TMP_Text channelText;
    [SerializeField] private Slider volumeSlider;

    [Header("Static / Transition")]
    [SerializeField] private GameObject staticOverlay;
    [SerializeField] private float staticDuration = 0.45f;

    [Header("Audio")]
    [SerializeField] private AudioSource tvAudioSource;
    [SerializeField] private AudioClip switchClip;
    [SerializeField] private AudioClip powerOnClip;
    [SerializeField] private AudioClip powerOffClip;

    private int currentChannel = 0;
    private bool isOn = false;
    private Coroutine switchingRoutine;

    private void Awake()
    {
        // выключаем всё
        if (channels != null)
        {
            for (int i = 0; i < channels.Length; i++)
                if (channels[i] != null) channels[i].SetActive(false);
        }

        if (staticOverlay != null) staticOverlay.SetActive(false);

        // громкость
        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(SetVolume);
            SetVolume(volumeSlider.value);
        }

        // стартуем включенным (если хочешь старт OFF — просто закомментируй эту строку и вызови PowerOff())
        PowerOn(startChannel);
    }

    public void PowerToggle()
    {
        if (isOn) PowerOff();
        else PowerOn(startChannel);
    }

    public void PowerOn(int channelToShow)
    {
        isOn = true;

        if (powerOnClip != null && tvAudioSource != null)
            tvAudioSource.PlayOneShot(powerOnClip);

        SetChannelInternal(Mathf.Clamp(channelToShow, 1, 3), playStatic: true);
    }

    public void PowerOff()
    {
        isOn = false;

        if (powerOffClip != null && tvAudioSource != null)
            tvAudioSource.PlayOneShot(powerOffClip);

        SetChannelInternal(0, playStatic: false);
    }

    public void NextChannel()
    {
        if (!isOn) return;

        int next = currentChannel + 1;
        if (next > 3) next = 1;
        SetChannelInternal(next, playStatic: true);
    }

    public void PrevChannel()
    {
        if (!isOn) return;

        int prev = currentChannel - 1;
        if (prev < 1) prev = 3;
        SetChannelInternal(prev, playStatic: true);
    }

    private void SetChannelInternal(int channelIndex, bool playStatic)
    {
        if (channels == null || channels.Length < 4) return;

        if (switchingRoutine != null)
            StopCoroutine(switchingRoutine);

        switchingRoutine = StartCoroutine(SwitchRoutine(channelIndex, playStatic));
    }

    private IEnumerator SwitchRoutine(int targetChannel, bool playStatic)
    {
        if (switchClip != null && tvAudioSource != null && isOn)
            tvAudioSource.PlayOneShot(switchClip);

        if (playStatic && staticOverlay != null)
        {
            staticOverlay.SetActive(true);
            yield return new WaitForSeconds(staticDuration);
            staticOverlay.SetActive(false);
        }

        for (int i = 0; i < channels.Length; i++)
            if (channels[i] != null) channels[i].SetActive(false);

        currentChannel = targetChannel;
        if (channels[currentChannel] != null)
            channels[currentChannel].SetActive(true);

        UpdateChannelText();
        switchingRoutine = null;
    }

    private void UpdateChannelText()
    {
        if (channelText == null) return;

        if (!isOn || currentChannel == 0)
            channelText.text = "OFF";
        else
            channelText.text = $"CHANNEL: {currentChannel}";
    }

    public void SetVolume(float value)
    {
        if (tvAudioSource != null)
            tvAudioSource.volume = value;
    }
}
