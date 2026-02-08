using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed; // скорость движени€
    [SerializeField] private int lives = 3;
    [SerializeField] private float jumpForce = 15f;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    public int score;
    public Text TextScore;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }
    private void Run()
    {
        if (isGrounded) State = States.run;

        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, _speed * Time.deltaTime);


       
        
        sprite.flipX = dir.x < 0.0f;

        
    }

    // сбор €блок
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Apple")
        {

            Destroy(collision.gameObject);


        }
    }


    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 1f);
        isGrounded = collider.Length > 1;

        if (!isGrounded) State = States.jump;
    }

    private void Update()
    {

        if (isGrounded) State = States.idle;
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        
        
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

}

public enum States
{
    idle,
    run,
    jump
}