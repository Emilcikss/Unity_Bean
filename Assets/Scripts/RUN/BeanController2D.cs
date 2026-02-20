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

    private Rigidbody2D rb;
    private float x;
    private bool uzZemes;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (animators == null) animators = GetComponent<Animator>();
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        if (zemesPunkts != null)
            uzZemes = Physics2D.OverlapCircle(zemesPunkts.position, zemesRadius, zemesSlanis);

        if (Input.GetKeyDown(KeyCode.Space) && uzZemes)
            rb.velocity = new Vector2(rb.velocity.x, leciens);

        if (x != 0)
            transform.localScale = new Vector3(Mathf.Sign(x), 1f, 1f);

        if (animators != null)
        {
            animators.SetFloat("Speed", Mathf.Abs(x));
            animators.SetBool("Grounded", uzZemes);
            animators.SetFloat("YVel", rb.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x * atrums, rb.velocity.y);
    }

    private void OnDrawGizmosSelected()
    {
        if (zemesPunkts == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(zemesPunkts.position, zemesRadius);
    }
}