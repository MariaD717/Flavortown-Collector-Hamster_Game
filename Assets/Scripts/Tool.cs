using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Movement>() != null)
        {
            scoreManager = collision.gameObject.GetComponent<ScoreManager>();
            scoreManager.addScore(1);
            Destroy(gameObject);
        }
    }
}


