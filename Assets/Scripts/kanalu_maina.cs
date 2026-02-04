using UnityEngine;

public class TVChannelCycler : MonoBehaviour
{
    public GameObject channel1;
    public GameObject channel2;
    public GameObject channel3Noise;

    private int currentChannel = 1;

    void Start()
    {
        ShowChannel();
    }

    // КНОПКА >
    public void NextChannel()
    {
        if (currentChannel < 3)
        {
            currentChannel++;
            ShowChannel();
        }
    }

    // КНОПКА <
    public void PrevChannel()
    {
        if (currentChannel > 1)
        {
            currentChannel--;
            ShowChannel();
        }
    }

    void ShowChannel()
    {
        channel1.SetActive(currentChannel == 1);
        channel2.SetActive(currentChannel == 2);
        channel3Noise.SetActive(currentChannel == 3);

        Debug.Log("CHANNEL: " + currentChannel);
    }
}
