using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player object's transform
    public float smoothSpeed = 0.125f; // Smoothing for camera follow movement
    public Vector3 offset; // Offset distance between the player and camera

    private Rigidbody playerRigidbody; // Reference to the player object's rigidbody

    private void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody>(); // Assign the player's rigidbody
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // Calculate the desired position of the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Apply smooth movement to the camera

        transform.position = smoothedPosition; // Update the position of the camera

        // Camera to follow the rotation of the player object
        // transform.rotation = player.rotation;
    }
}