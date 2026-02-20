using UnityEngine;

public class BeanController2D : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float atrums = 6f;
    [SerializeField] private float leciens = 12f;

    [Header("Ground Check")]
    [SerializeField] private Transform zemesPunkts;
    [SerializeField] private float zemesRadius = 0.16f;
    [SerializeField] private LayerMask zemesSlanis;

    [Header("Animator")]
    [SerializeField] private Animator animators;

    [Header("Sprite")]
    [SerializeField] private SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;
    private float x;
    private bool uzZemes;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (animators == null)
            animators = GetComponentInChildren<Animator>();

        if (spriteRenderer == null)
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        // Input
        x = Input.GetAxisRaw("Horizontal");

        // Flip without changing scale
        if (spriteRenderer != null)
        {
            if (x > 0) spriteRenderer.flipX = false;
            else if (x < 0) spriteRenderer.flipX = true;
        }

        // Ground check
        if (zemesPunkts != null)
            uzZemes = Physics2D.OverlapCircle(zemesPunkts.position, zemesRadius, zemesSlanis);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && uzZemes)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, leciens);

        // Animator params
        if (animators != null)
        {
            animators.SetFloat("Speed", Mathf.Abs(x));
            animators.SetBool("Grounded", uzZemes);
            animators.SetFloat("YVel", rb.linearVelocity.y);
        }
    }

    private void FixedUpdate()
    {
        // Move
        rb.linearVelocity = new Vector2(x * atrums, rb.linearVelocity.y);
    }

    private void OnDrawGizmosSelected()
    {
        if (zemesPunkts == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(zemesPunkts.position, zemesRadius);
    }
}