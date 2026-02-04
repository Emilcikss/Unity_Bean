using UnityEngine;

public class TVChannelCycler : MonoBehaviour
{

    public GameObject channel1;
    public GameObject channel2;
    public GameObject channel3Noise;

 
    [Range(1, 3)]
    public int startChannel = 1;

    private int currentChannel;

    private void Start()
    {
        currentChannel = startChannel;
        ApplyChannel();
    }

  
    public void NextChannel()
    {
        if (currentChannel < 3)
        {
            currentChannel++;
            ApplyChannel();
        }
        
    }

    public void PrevChannel()
    {
        if (currentChannel > 1)
        {
            currentChannel--;
            ApplyChannel();
        }
    }

    private void ApplyChannel()
    {
        if (channel1 != null) channel1.SetActive(currentChannel == 1);
        if (channel2 != null) channel2.SetActive(currentChannel == 2);
        if (channel3Noise != null) channel3Noise.SetActive(currentChannel == 3);

        Debug.Log("Current channel: " + currentChannel);
    }
}
