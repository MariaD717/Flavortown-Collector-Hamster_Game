using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public GameObject Food;
    public int scoreAdd = 1;
    public int playerScore;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Movement>() != null)
        {
            addPoint();
            Destroy(Food.gameObject);
        }
    }
    void addPoint()
    {
        print("Plus Point");

    }
    public void addScore(int scoreAdd)
    {
        playerScore += scoreAdd;
        scoreText.text += playerScore.ToString();
    }

}


