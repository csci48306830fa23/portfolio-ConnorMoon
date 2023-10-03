using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public GameObject objectToScale;
    public float minScale = 0.1f;
    public float maxScale = 2.0f;

    public void UpdateScale(float value)
    {
        // Calculate the new scale based on the slider value
        float newScale = Mathf.Lerp(minScale, maxScale, value);

        // Apply the new scale uniformly to the object
        objectToScale.transform.localScale = new Vector3(newScale, newScale, newScale);
    }

    public void UpdateScaleX(float value)
    {
        // Calculate the new scale along the X-axis based on the slider value
        float newScaleX = Mathf.Lerp(minScale, maxScale, value);

        // Keep the current scale along the Y and Z axes
        Vector3 currentScale = objectToScale.transform.localScale;
        objectToScale.transform.localScale = new Vector3(newScaleX, currentScale.y, currentScale.z);
    }

    public void UpdateScaleY(float value)
    {
        // Calculate the new scale along the Y-axis based on the slider value
        float newScaleY = Mathf.Lerp(minScale, maxScale, value);

        // Keep the current scale along the X and Z axes
        Vector3 currentScale = objectToScale.transform.localScale;
        objectToScale.transform.localScale = new Vector3(currentScale.x, newScaleY, currentScale.z);
    }

    public void UpdateScaleZ(float value)
    {
        // Calculate the new scale along the Z-axis based on the slider value
        float newScaleZ = Mathf.Lerp(minScale, maxScale, value);

        // Keep the current scale along the X and Y axes
        Vector3 currentScale = objectToScale.transform.localScale;
        objectToScale.transform.localScale = new Vector3(currentScale.x, currentScale.y, newScaleZ);
    }
}