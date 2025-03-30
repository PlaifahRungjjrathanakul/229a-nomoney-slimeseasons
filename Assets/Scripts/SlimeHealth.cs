using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    public int health = 100;  

    public void TakeDamage(int damage)
    {
        health -= damage;  

        if (health <= 0)
        {
            Die();  
        }
    }

    private void Die()
    {
        
        Debug.Log("Slime died!");
        
    }
}