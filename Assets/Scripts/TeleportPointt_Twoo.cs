using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPointt_Twoo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HeartSystem.health -= 3;
        }

        if (HeartSystem.health <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

}
