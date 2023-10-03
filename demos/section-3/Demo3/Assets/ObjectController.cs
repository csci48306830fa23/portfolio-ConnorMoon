using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    public GameObject[] objectsToControl; // Array of GameObjects to show/hide


    private GameObject currentSelectedObject;


    public Material materialOption1; // Assign this material in the Unity Inspector for Option 1.
    public Material materialOption2; // Assign this material in the Unity Inspector for Option 2.
    public Material materialOption3; // Assign this material in the Unity Inspector for Option 3.



    public void Sample(int index)
    {
        currentSelectedObject = objectsToControl[index];
        
        HideAllObjects();
        // Use a switch case to perform actions based on the selected option.
        switch (index)
        {
            case 0:
                Debug.Log("Option 1 selected");
                objectsToControl[index].SetActive(true);
                currentSelectedObject = objectsToControl[index];
                // Add your code for Option 1 here.
                break;
            case 1:
                Debug.Log("Option 2 selected");
                objectsToControl[index].SetActive(true);
                currentSelectedObject = objectsToControl[index];
                break;
            case 2:
                Debug.Log("Option 3 selected");
                objectsToControl[index].SetActive(true);
                currentSelectedObject = objectsToControl[index];
                break;
            // Add more cases as needed.
            default:
                Debug.LogError("Invalid option selected");
                break;

            
        }
    }

    public void ChangeMaterial(int materialOption)
    {
        Material newMaterial = null;
        // Determine which material to use based on the materialOption parameter.
        switch (materialOption)
        {
            case 0:
                newMaterial = materialOption1;
                break;
            case 1:
                newMaterial = materialOption2;
                break;
            case 2:
                newMaterial = materialOption3;
                break;
            default:
                Debug.LogError("Invalid material option");
                break;
        }

        if (newMaterial != null && currentSelectedObject != null)
        {
            Renderer objectRenderer = currentSelectedObject.GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                objectRenderer.material = newMaterial;
            }
            else
            {
                Debug.LogError("Selected object does not have a Renderer component.");
            }
        }
    }


    public void HideAllObjects()
    {
        // Hide all objects in the array except the currently selected one
        foreach (var obj in objectsToControl)
        {
            if (obj != currentSelectedObject)
            {
                obj.SetActive(false);
            }
        }
    }
}