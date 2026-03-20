using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int playerScore = 0;

    public void addScore(int scoreAdd)
    {
        playerScore += scoreAdd;
        scoreText.text = playerScore.ToString();
    }
}
