using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreMinus : MonoBehaviour
{

    private ScoreManager scoreManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Movement>() != null)
        {
            scoreManager = collision.gameObject.GetComponent<ScoreManager>();
            scoreManager.addScore(-1);
            Destroy(gameObject);
        }
    }
}
