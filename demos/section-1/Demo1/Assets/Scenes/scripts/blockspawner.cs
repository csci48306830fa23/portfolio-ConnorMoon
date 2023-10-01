using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspawner : MonoBehaviour
{
    public GameObject blockPrefab; // Reference to the block prefab
    public KeyCode spawnKey = KeyCode.Space; // Key to spawn the block
    public float spawnInterval = 1.0f; // Interval between spawns
    private float lastSpawnTime = 0.0f; // Time of the last spawn

    void Update()
    {
        // Check if the spawn key is pressed and enough time has passed since the last spawn
        if (Input.GetKeyDown(spawnKey) && Time.time - lastSpawnTime >= spawnInterval)
        {
            // Spawn the block at the spawner's position without considering rotation
            Instantiate(blockPrefab, transform.position, Quaternion.identity);
            
            // Update the last spawn time
            lastSpawnTime = Time.time;
        }
    }
}
