using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballSpawner : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public float initialSpeed = 10.0f; // Initial speed of the spawned object
    public float pitchAngle = 45.0f; // Pitch angle in degrees
    public float yawAngle = 0.0f;   // Yaw angle in degrees

    // Update is called once per frame
    void Update()
    {
        // Check if the spawn key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calculate the launch velocity based on the initial speed and angles
            Vector3 launchVelocity = CalculateLaunchVelocity();

            // Create an instance of the object with the parent's position and rotation
            GameObject spawnedObject = Instantiate(cannonBallPrefab, transform.position, Quaternion.Euler(pitchAngle, yawAngle, 0));

            // Access the Rigidbody of the spawned object
            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = launchVelocity;
            }
            else
            {
                Debug.LogWarning("The spawned object does not have a Rigidbody component.");
            }
        }
    }

    private Vector3 CalculateLaunchVelocity()
    {
        // Calculate the launch velocity based on the initial speed and angles
        float pitchAngleRad = pitchAngle * Mathf.Deg2Rad;
        float yawAngleRad = yawAngle * Mathf.Deg2Rad;

        float launchVelocityX = initialSpeed * Mathf.Cos(pitchAngleRad) * Mathf.Cos(yawAngleRad);
        float launchVelocityY = initialSpeed * Mathf.Cos(pitchAngleRad) * Mathf.Sin(yawAngleRad);
        float launchVelocityZ = initialSpeed * Mathf.Sin(pitchAngleRad);

        return new Vector3(launchVelocityX, launchVelocityY, launchVelocityZ);
    }
}
