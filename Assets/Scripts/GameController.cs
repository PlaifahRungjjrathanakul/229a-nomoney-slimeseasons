using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;  

public class GameController : MonoBehaviour
{
    
    public void StartGame()
    {
        
        SceneManager.LoadScene("GameScene"); 
    }

    
    public void ReplayGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
