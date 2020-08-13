using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    //gives the player movement RigidBody a variable
    public Rigidbody rb;
    
    //allows for the forward speed to be adjusted in Unity
    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;
    // Update is called once per frame
    //FixedUpdate is used for physics updates
    void FixedUpdate()
    {
        //use Time.deltaTime to keep even force regardless of FPS
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("l"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("j"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
