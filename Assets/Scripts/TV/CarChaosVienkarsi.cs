using UnityEngine;
using UnityEngine.EventSystems;

public class CarChaosVienkarsi : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject carsFront;
    [SerializeField] private GameObject carsBack;

    [SerializeField] private GameObject beanStand;
    [SerializeField] private GameObject beanFall;

    [SerializeField] private AudioSource audioAvots;
    [SerializeField] private AudioClip skanja;

    [SerializeField] private string atslega = "car_chaos_done";

    private void OnEnable()
    {
        bool noticis = PlayerPrefs.GetInt(atslega, 0) == 1;
        UzliktStavokli(noticis);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt(atslega, 0) == 1) return;

        if (audioAvots != null && skanja != null)
            audioAvots.PlayOneShot(skanja);

        PlayerPrefs.SetInt(atslega, 1);
        PlayerPrefs.Save();

        UzliktStavokli(true);
    }

    private void UzliktStavokli(bool noticis)
    {
        if (carsFront != null) carsFront.SetActive(!noticis);
        if (carsBack != null)  carsBack.SetActive(noticis);

        if (beanStand != null) beanStand.SetActive(!noticis);
        if (beanFall != null)  beanFall.SetActive(noticis);
    }
}
