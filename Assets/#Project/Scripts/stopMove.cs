using UnityEngine;

public class stopMove : MonoBehaviour
{
    public Rigidbody rb; 
    private void OnCollisionEnter(Collision collision)
    {
        if (rb.CompareTag("Finish"))
        {

        }
    }
}
