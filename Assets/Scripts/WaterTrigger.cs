using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public int damageAmount = 10;  

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))  
        {
            
            SlimeHealth slimeHealth = other.GetComponent<SlimeHealth>();
            if (slimeHealth != null)
            {
                slimeHealth.TakeDamage(damageAmount);  
            }
        }
    }
}