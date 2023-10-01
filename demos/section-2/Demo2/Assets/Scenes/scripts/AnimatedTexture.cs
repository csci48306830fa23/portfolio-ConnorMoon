using UnityEngine;

public class AnimatedTexture : MonoBehaviour
{
    public Material animatedMaterial;  // Reference to the material with the animated texture
    public Texture2D[] frameTextures;  // Array of frame textures
    public float framesPerSecond = 10f; // Animation speed in frames per second

    private int currentFrame = 0;
    private float timer = 0f;

    void Start()
    {
        // Set the initial texture
        if (animatedMaterial != null && frameTextures.Length > 0)
        {
            animatedMaterial.mainTexture = frameTextures[currentFrame];
        }
    }

    void Update()
    {
        // Calculate the time per frame
        float timePerFrame = 1f / framesPerSecond;

        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to change frames
        if (timer >= timePerFrame)
        {
            // Reset the timer
            timer -= timePerFrame;

            // Increment the frame index and wrap around
            currentFrame = (currentFrame + 1) % frameTextures.Length;

            // Update the material's texture
            if (animatedMaterial != null)
            {
                animatedMaterial.mainTexture = frameTextures[currentFrame];
            }
        }
    }
}