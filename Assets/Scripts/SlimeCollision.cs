using UnityEngine;

public class SlimeCollision : MonoBehaviour
{
    public int maxHP = 100; 
    public int currentHP; 

    void Start()
    {
        currentHP = maxHP; 
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Fence"))
        {
            
            currentHP -= 5;
            if (currentHP < 0) currentHP = 0; 
            Debug.Log("Current HP: " + currentHP); 

            
        }
    }
}