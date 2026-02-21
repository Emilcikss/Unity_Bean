using UnityEngine;

public class FallingItem : MonoBehaviour
{
    public enum Tips { Labs, Slikts }

    [Header("Type")]
    public Tips tips = Tips.Labs;

    [Header("Values")]
    public int punkti = 1;     // donut
    public int bojajums = 1;   // anvil

    [Header("Fall Speed")]
    public float minAtrums = 4f;
    public float maxAtrums = 9f;

    private float atrums;

    private void Start()
    {
        atrums = Random.Range(minAtrums, maxAtrums);
    }

    private void Update()
    {
        transform.position += Vector3.down * atrums * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var gm = FindFirstObjectByType<GameManagerRun>();
            if (gm != null)
            {
                if (tips == Tips.Labs) gm.AddScore(punkti);
                else gm.TakeHit(bojajums);
            }

            Destroy(gameObject);
            return;
        }

        if (other.CompareTag("DestroyZone"))
        {
            Destroy(gameObject);
        }
    }
}