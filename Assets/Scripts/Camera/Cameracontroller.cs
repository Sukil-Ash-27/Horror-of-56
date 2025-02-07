using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player; // Reference to the player's Transform

    // Update is called once per frame
    void Update()
    {
        if (player != null) // Ensure player is assigned
        {
            // Update the camera's position to follow the player on X and Y, keep Z constant
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}
