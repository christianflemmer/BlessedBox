using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    // Vector3 stores three floats, good for positioning (ie. x, y and z)
    public Vector3 offset;

    private void Update(

    ) {
        // Set this GameObject's position (ie. the Main Camera) to the player position.
        transform.position = player.position + offset;
    }
}
