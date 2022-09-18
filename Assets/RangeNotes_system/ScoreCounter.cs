using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    public Text scoreDisplay;

    public void AddScore(int point)
    {
        score += point;
        scoreDisplay.text = $"Score {score}";
    }

    //Score•\Ž¦

}
