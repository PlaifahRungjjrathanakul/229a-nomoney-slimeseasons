using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float pushForce = 10f;
    private Rigidbody rb;

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

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(transform.forward * pushForce, ForceMode.Impulse);
                }
            }
        }
    }
}