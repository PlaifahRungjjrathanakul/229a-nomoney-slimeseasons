using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  
    public TextMeshProUGUI timeText;   
    private float timer = 0f;  
    private int score = 0;     

    public float gameDuration = 60f;  
    public int targetScore = 30;      

    void Start()
    {
        
        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + Mathf.Floor(timer);
    }

    void Update()
    {
        
        timer += Time.deltaTime;
        timeText.text = "Time: " + Mathf.Floor(timer);

        
        if (score < targetScore && timer < gameDuration)
        {
            
            score++;
            scoreText.text = "Score: " + score;
        }

        
        if (timer >= gameDuration || score >= targetScore)
        {
            EndGame();
        }
    }

    
    void EndGame()
    {
        
        Debug.Log("Game Over! Time's up or Score reached!");
        scoreText.text = "Final Score: " + score;
        timeText.text = "Time: " + Mathf.Floor(timer);

        
        score = 0;
        timer = 0f;
        
    }
}
