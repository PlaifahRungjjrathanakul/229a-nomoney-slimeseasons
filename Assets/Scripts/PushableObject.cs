using UnityEngine;

public class PushableObject : MonoBehaviour
{
    public float pushStrength = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slime"))
        {
            Rigidbody slimeRb = collision.gameObject.GetComponent<Rigidbody>();
            if (slimeRb != null)
            {
                Vector3 pushDirection = collision.transform.forward;
                slimeRb.AddForce(pushDirection * pushStrength, ForceMode.Impulse);
            }
        }
    }
}