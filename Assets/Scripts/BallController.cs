using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 10f;  
    public float rotationSpeed = 100f;  
    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");  
        float moveVertical = Input.GetAxis("Vertical");      

        
        Vector3 moveDirection = new Vector3(moveHorizontal, 0f, moveVertical);

        
        rb.AddForce(moveDirection * moveSpeed);

        
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            
            float turn = moveHorizontal * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, turn, 0);
        }
    }
}
