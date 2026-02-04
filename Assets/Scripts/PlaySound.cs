using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;

    public void Play()
    {
        audioSource.PlayOneShot(sound);
    }
}
