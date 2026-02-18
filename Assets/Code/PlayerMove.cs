using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust, rotThrust;
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.K) && (Mathf.Abs(rb.linearVelocity.magnitude) < 30))
        {
            rb.AddForce(transform.forward * thrust * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.A) && (Mathf.Abs(rb.angularVelocity.magnitude) < 1))
        {
            rb.AddTorque(transform.up * -rotThrust * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D) && (Mathf.Abs(rb.angularVelocity.magnitude) < 1))
        {
            rb.AddTorque(transform.up * rotThrust * Time.deltaTime);
        }
    }
}