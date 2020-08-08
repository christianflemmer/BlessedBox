using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    // We marked this as "Fixed"Updated because we are using it to mess with physics.
    private void FixedUpdate()
    {
        // Add a forward force
        rigidBody.AddForce(0, 0, (forwardForce * Time.deltaTime));

        if (isMovingLeft)
        {
            rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (isMovingRight)
        {
            rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // If the player falls off the edge
        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void Update()
    {
        // In order to not miss some player input, save variables in this method.
        isMovingLeft = Input.GetKey("a");
        isMovingRight = Input.GetKey("d");
    }
}
