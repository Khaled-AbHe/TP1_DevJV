using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class MouvementRobot : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;

    private Rigidbody2D corps;
    private Vector2 direction;
    private Animator animator;

    private void Awake()
    {
        corps = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector2(horizontal, vertical).normalized;
        animator.SetBool("EnMouvement", direction.sqrMagnitude > 0.01f);
    }

    private void FixedUpdate()
    {
        corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
    }
}

