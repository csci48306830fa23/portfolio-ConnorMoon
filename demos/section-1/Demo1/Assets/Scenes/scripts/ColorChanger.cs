using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Renderer targetRenderer; // Reference to the object's Renderer component
    public Material[] materials; // Array of materials to cycle through

    private int currentIndex = 0; // Index of the currently selected material

    void Start()
    {
        // Initialize the object with the first material in the array
        if (targetRenderer != null && materials.Length > 0)
        {
            targetRenderer.material = materials[currentIndex];
        }
    }

    void Update()
    {
        // Check for left arrow key input
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Decrement the index and cycle to the previous material
            currentIndex = (currentIndex - 1 + materials.Length) % materials.Length;
            UpdateMaterial();
        }

        // Check for right arrow key input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Increment the index and cycle to the next material
            currentIndex = (currentIndex + 1) % materials.Length;
            UpdateMaterial();
        }
    }

    // Helper function to update the object's material
    void UpdateMaterial()
    {
        if (targetRenderer != null && materials.Length > 0)
        {
            targetRenderer.material = materials[currentIndex];
        }
    }
}