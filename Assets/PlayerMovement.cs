using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    //gives the player movement RigidBody a variable
    public Rigidbody rb;


    // Update is called once per frame
    //FixedUpdate is used for physics updates
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
