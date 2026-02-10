using UnityEngine;
using UnityEngine.EventSystems;

public class ClickSFX : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clickClip;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (audioSource == null)
        {
            Debug.LogError("ClickSFX: AudioSource not assigned");
            return;
        }

        if (clickClip == null)
        {
            Debug.LogError("ClickSFX: AudioClip not assigned");
            return;
        }

        audioSource.PlayOneShot(clickClip);
        Debug.Log("CLICK SOUND: " + gameObject.name);
    }
}
