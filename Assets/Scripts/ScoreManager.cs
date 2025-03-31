using UnityEngine;
using TMPro;  

public class ScoreManager : MonoBehaviour
{
    public int score = 0;  
    public TextMeshProUGUI scoreText;  

    
    void Start()
    {
        
        UpdateScoreText();
    }

    
    public void AddScore(int amount)
    {
        score += amount;  
        UpdateScoreText();  
    }

    
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();  
    }

    
    public void ResetScore()
    {
        score = 0;  
        UpdateScoreText();  
    }
}
