using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private GameObject donutPrefab;
    [SerializeField] private GameObject anvilPrefab;

    [Header("Spawn Area")]
    [SerializeField] private float xMin = -8f;
    [SerializeField] private float xMax = 8f;
    [SerializeField] private float ySpawn = 6f;

    [Header("Spawn Timing")]
    [SerializeField] private float startInterval = 0.9f;
    [SerializeField] private float minInterval = 0.35f;
    [SerializeField] private float difficultyStep = 0.03f;     // как быстро ускоряемся
    [SerializeField] private float stepEverySeconds = 6f;      // каждые X секунд ускорять

    [Header("Chances")]
    [SerializeField, Range(0f, 1f)] private float anvilChance = 0.30f;

    private bool running = false;
    private float timer = 0f;
    private float interval;
    private float diffTimer = 0f;

    public void StartSpawn()
    {
        running = true;
        timer = 0f;
        diffTimer = 0f;
        interval = startInterval;
    }

    public void StopSpawn()
    {
        running = false;
    }

    private void Update()
    {
        if (!running) return;

        timer += Time.deltaTime;
        diffTimer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;
            SpawnOne();
        }

        if (diffTimer >= stepEverySeconds)
        {
            diffTimer = 0f;
            interval = Mathf.Max(minInterval, interval - difficultyStep);
        }
    }

    private void SpawnOne()
    {
        if (donutPrefab == null || anvilPrefab == null) return;

        float x = Random.Range(xMin, xMax);
        Vector3 pos = new Vector3(x, ySpawn, 0f);

        bool spawnAnvil = Random.value < anvilChance;
        Instantiate(spawnAnvil ? anvilPrefab : donutPrefab, pos, Quaternion.identity);
    }
}