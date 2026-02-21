using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManagerRun : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private Button startButton;
    [SerializeField] private Image[] hearts; // 3 images

    [Header("Systems")]
    [SerializeField] private ItemSpawner spawner;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip collectSFX;
    [SerializeField] private AudioClip hitSFX;

    [Header("Stats")]
    [SerializeField] private int startLives = 3;

    private int score;
    private int lives;
    private float time;
    private bool playing;

    private void Start()
    {
        ResetUI();

        if (startButton != null)
            startButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        score = 0;
        lives = startLives;
        time = 0f;
        playing = true;

        if (gameOverText != null) gameOverText.gameObject.SetActive(false);
        if (startButton != null) startButton.gameObject.SetActive(false);

        UpdateUI();

        if (spawner != null) spawner.StartSpawn();
    }

    private void Update()
    {
        if (!playing) return;

        time += Time.deltaTime;
        UpdateTimeUI();
    }

    public void AddScore(int amount)
    {
        if (!playing) return;

        score += amount;
        PlaySFX(collectSFX);
        UpdateScoreUI();
    }

    public void TakeHit(int amount)
    {
        if (!playing) return;

        lives -= amount;
        if (lives < 0) lives = 0;

        PlaySFX(hitSFX);
        UpdateHeartsUI();

        if (lives == 0)
            GameOver();
    }

    private void GameOver()
    {
        playing = false;

        if (spawner != null) spawner.StopSpawn();

        if (gameOverText != null)
        {
            gameOverText.text = "GAME OVER";
            gameOverText.gameObject.SetActive(true);
        }

        if (startButton != null)
            startButton.gameObject.SetActive(true);
    }

    private void ResetUI()
    {
        score = 0;
        lives = startLives;
        time = 0f;
        playing = false;

        if (gameOverText != null) gameOverText.gameObject.SetActive(false);
        if (startButton != null) startButton.gameObject.SetActive(true);

        UpdateUI();
    }

    private void UpdateUI()
    {
        UpdateScoreUI();
        UpdateTimeUI();
        UpdateHeartsUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = $"SCORE: {score}";
    }

    private void UpdateTimeUI()
    {
        if (timeText == null) return;

        int min = Mathf.FloorToInt(time / 60f);
        int sec = Mathf.FloorToInt(time % 60f);
        timeText.text = $"{min:00}:{sec:00}";
    }

    private void UpdateHeartsUI()
    {
        if (hearts == null) return;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (hearts[i] != null)
                hearts[i].enabled = (i < lives);
        }
    }

    private void PlaySFX(AudioClip clip)
    {
        if (audioSource == null || clip == null) return;
        audioSource.PlayOneShot(clip);
    }
}