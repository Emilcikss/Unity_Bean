using UnityEngine;

public class AutoPlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;

    void Start()
    {
        audioSource.clip = sound;
        audioSource.Play();
    }
}
