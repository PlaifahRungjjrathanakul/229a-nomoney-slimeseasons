using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        
        rb.AddForce(movement * speed);
    }
}
