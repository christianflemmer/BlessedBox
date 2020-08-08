using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    // Build in Unity function
    private void OnCollisionEnter(
        Collision collision
    )
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
             FindObjectOfType<GameManager>().EndGame();
        }
    }
}
