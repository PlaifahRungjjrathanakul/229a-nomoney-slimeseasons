using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    private Rigidbody rb;  
    public float moveSpeed = 5f;  

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");  
        float moveVertical = Input.GetAxis("Vertical");     

        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        
        rb.AddForce(movement * moveSpeed);  
    }
}