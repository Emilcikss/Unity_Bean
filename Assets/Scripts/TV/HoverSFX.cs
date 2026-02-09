using UnityEngine;
using UnityEngine.EventSystems;

public class HoverSFX : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hoverClip;
    [SerializeField] private bool playOnceUntilExit = true;

    private bool hasPlayed;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audioSource == null || hoverClip == null) return;

        if (playOnceUntilExit && hasPlayed) return;

        audioSource.PlayOneShot(hoverClip);
        hasPlayed = true;

        Debug.Log("HOVER: " + gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hasPlayed = false;
    }
}
