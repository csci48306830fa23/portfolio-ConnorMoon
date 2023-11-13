using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{
    public GameObject objectToSpawn; // Assign your prefab in the Inspector
    public float speed = 3;

    // Method to spawn the object at the script's host position
    public void SpawnObject()
    {
        // Check if the objectToSpawn is assigned
        if (objectToSpawn != null)
        {
            // Instantiate the object at the position of the host GameObject
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Object to spawn is not assigned in the Inspector.");
        }
    }

    // Method to spawn the object at the script's host position
    public void SpawnObjectUpwards()
    {
        // Check if the objectToSpawn is assigned
        if (objectToSpawn != null)
        {
            // Instantiate the object at the position of the host GameObject
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Add an initial velocity pointing up
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.up * speed;
            }
        }
        else
        {
            Debug.LogError("Object to spawn is not assigned in the Inspector.");
        }
    }

    // Method to spawn the object with initial velocity pointing down
    public void SpawnObjectDown()
    {
        // Check if the objectToSpawn is assigned
        if (objectToSpawn != null)
        {
            // Instantiate the object at the position of the host GameObject
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Add an initial velocity pointing down
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.down * speed;
            }
        }
        else
        {
            Debug.LogError("Object to spawn is not assigned in the Inspector.");
        }
    }

    // Method to spawn the object with initial velocity pointing left
    public void SpawnObjectLeft()
    {
        // Check if the objectToSpawn is assigned
        if (objectToSpawn != null)
        {
            // Instantiate the object at the position of the host GameObject
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Add an initial velocity pointing left
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.left * speed;
            }
        }
        else
        {
            Debug.LogError("Object to spawn is not assigned in the Inspector.");
        }
    }

    // Method to spawn the object with initial velocity pointing right
    public void SpawnObjectRight()
    {
        // Check if the objectToSpawn is assigned
        if (objectToSpawn != null)
        {
            // Instantiate the object at the position of the host GameObject
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Add an initial velocity pointing right
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.right * speed;
            }
        }
        else
        {
            Debug.LogError("Object to spawn is not assigned in the Inspector.");
        }
    }
}