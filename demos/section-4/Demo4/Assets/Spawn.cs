using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn; // The object you want to spawn

    public void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            // Get the position of this GameObject (the empty)
            Vector3 spawnPosition = transform.position;

            // Instantiate the object at the empty's position
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Object to spawn is not set!");
        }
    }
}
