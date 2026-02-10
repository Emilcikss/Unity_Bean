using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TVKontrolieris : MonoBehaviour
{
    [Header("Kanāli (0 = melns/izslēgts, 1..3 = īstie kanāli)")]
    [SerializeField] private GameObject[] kanali;      // izmērs 4: 0..3
    [SerializeField] private int sakumaKanals = 1;

    [Header("UI")]
    [SerializeField] private TMP_Text kanalaTeksts;
    [SerializeField] private Slider skanasSlidnis;

    [Header("Troksnis (pārslēgšana)")]
    [SerializeField] private GameObject troknaParsegs;
    [SerializeField] private float troknaIlgums = 0.45f;

    [Header("Skaņas avoti")]
    [SerializeField] private AudioSource tvSkanasAvots;
    [SerializeField] private AudioSource troknaSkanasAvots;

    [Header("SFX")]
    [SerializeField] private AudioClip parsledzSfx;
    [SerializeField] private AudioClip ieslegtSfx;
    [SerializeField] private AudioClip izslegtSfx;

    [Header("Troksnis (fade)")]
    [SerializeField] private float troknaFadeIn = 0.05f;
    [SerializeField] private float troknaFadeOut = 0.08f;
    [SerializeField, Range(0f, 1f)] private float troknaRelativaisSkanums = 0.6f;

    private int pasreizejaisKanals = 0;
    private bool irIeslegts = false;

    private Coroutine parsledzRutina;
    private Coroutine troknaFadeRutina;

    private float bzesSkanums = 1f;

    private void Awake()
    {
        if (kanali != null)
        {
            for (int i = 0; i < kanali.Length; i++)
                if (kanali[i] != null) kanali[i].SetActive(false);
        }

        if (troknaParsegs != null) troknaParsegs.SetActive(false);

        if (skanasSlidnis != null)
        {
            skanasSlidnis.onValueChanged.AddListener(IestatitSkanumu);
            IestatitSkanumu(skanasSlidnis.value);
        }
        else
        {
            IestatitSkanumu(1f);
        }

        IeslegtTV(sakumaKanals);
    }

    public void Barosana()
    {
        if (irIeslegts) IzslegtTV();
        else IeslegtTV(sakumaKanals);
    }

    public void IeslegtTV(int kanalsKoRadit)
    {
        irIeslegts = true;

        if (ieslegtSfx != null && tvSkanasAvots != null)
            tvSkanasAvots.PlayOneShot(ieslegtSfx);

        int mērķaKanals = Mathf.Clamp(kanalsKoRadit, 1, 3);
        UzliktKanaluIekseji(mērķaKanals, true);
    }

    public void IzslegtTV()
    {
        irIeslegts = false;

        if (izslegtSfx != null && tvSkanasAvots != null)
            tvSkanasAvots.PlayOneShot(izslegtSfx);

        TroknaSkanuIzslegt();
        UzliktKanaluIekseji(0, false);
    }

    public void NakosaisKanals()
    {
        if (!irIeslegts) return;

        int nak = pasreizejaisKanals + 1;
        if (nak > 3) nak = 1;

        UzliktKanaluIekseji(nak, true);
    }

    public void IeprieksejaisKanals()
    {
        if (!irIeslegts) return;

        int iepr = pasreizejaisKanals - 1;
        if (iepr < 1) iepr = 3;

        UzliktKanaluIekseji(iepr, true);
    }

    public int DabutPasreizejoKanalu() => pasreizejaisKanals;
    public bool VaiIrIeslegts() => irIeslegts;

    private void UzliktKanaluIekseji(int kanalaIndekss, bool raditTrokni)
    {
        if (kanali == null || kanali.Length < 4) return;

        if (parsledzRutina != null)
            StopCoroutine(parsledzRutina);

        parsledzRutina = StartCoroutine(ParsledzRutina(kanalaIndekss, raditTrokni));
    }

    private IEnumerator ParsledzRutina(int merkaKanals, bool raditTrokni)
    {
        if (parsledzSfx != null && tvSkanasAvots != null && irIeslegts)
            tvSkanasAvots.PlayOneShot(parsledzSfx);

        if (raditTrokni && troknaParsegs != null)
        {
            troknaParsegs.SetActive(true);
            TroknaSkanuIeslegt();

            yield return new WaitForSeconds(troknaIlgums);

            troknaParsegs.SetActive(false);
            TroknaSkanuIzslegt();
        }

        for (int i = 0; i < kanali.Length; i++)
            if (kanali[i] != null) kanali[i].SetActive(false);

        pasreizejaisKanals = merkaKanals;

        if (kanali[pasreizejaisKanals] != null)
            kanali[pasreizejaisKanals].SetActive(true);

        AtjaunotTekstu();
        parsledzRutina = null;
    }

    private void AtjaunotTekstu()
    {
        if (kanalaTeksts == null) return;

        if (!irIeslegts || pasreizejaisKanals == 0)
            kanalaTeksts.text = "OFF";
        else
            kanalaTeksts.text = $"KANĀLS: {pasreizejaisKanals}";
    }

    public void IestatitSkanumu(float vertiba)
    {
        bzesSkanums = Mathf.Clamp01(vertiba);

        if (tvSkanasAvots != null)
            tvSkanasAvots.volume = bzesSkanums;

        if (troknaSkanasAvots != null)
            troknaSkanasAvots.volume = bzesSkanums * troknaRelativaisSkanums;
    }

    private void TroknaSkanuIeslegt()
    {
        if (troknaSkanasAvots == null) return;

        if (!troknaSkanasAvots.isPlaying)
            troknaSkanasAvots.Play();

        if (troknaFadeRutina != null) StopCoroutine(troknaFadeRutina);

        float merkis = bzesSkanums * troknaRelativaisSkanums;
        troknaFadeRutina = StartCoroutine(FadeSkanums(troknaSkanasAvots, merkis, troknaFadeIn));
    }

    private void TroknaSkanuIzslegt()
    {
        if (troknaSkanasAvots == null) return;

        if (troknaFadeRutina != null) StopCoroutine(troknaFadeRutina);
        troknaFadeRutina = StartCoroutine(FadeUzNulliUnStop(troknaSkanasAvots, troknaFadeOut));
    }

    // svarīgi: fade izmanto Time.unscaledDeltaTime, lai nekas nečakarējas, ja Time.timeScale mainās
    private IEnumerator FadeSkanums(AudioSource avots, float merkis, float ilgums)
    {
        float sakums = avots.volume;
        float t = 0f;

        if (ilgums <= 0f)
        {
            avots.volume = merkis;
            yield break;
        }

        while (t < ilgums)
        {
            t += Time.unscaledDeltaTime;
            avots.volume = Mathf.Lerp(sakums, merkis, t / ilgums);
            yield return null;
        }

        avots.volume = merkis;
    }

    private IEnumerator FadeUzNulliUnStop(AudioSource avots, float ilgums)
    {
        float sakums = avots.volume;
        float t = 0f;

        if (ilgums <= 0f)
        {
            avots.volume = 0f;
            avots.Stop();
            yield break;
        }

        while (t < ilgums)
        {
            t += Time.unscaledDeltaTime;
            avots.volume = Mathf.Lerp(sakums, 0f, t / ilgums);
            yield return null;
        }

        avots.volume = 0f;
        avots.Stop();
    }
}
