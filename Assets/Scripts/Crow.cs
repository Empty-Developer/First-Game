using UnityEngine;
using UnityEngine.SceneManagement;
public class Crow : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.gravityScale = 0;
        rb.AddForce(-transform.position * Time.deltaTime / 0.2f, ForceMode2D.Impulse);
    }

    
}
