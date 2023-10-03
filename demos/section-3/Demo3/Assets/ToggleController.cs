using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;  // Reference to the GameObject you want to activate or deactivate


    public void OnToggleCube(bool isOn)
    {
        // Check if the toggle is selected (isOn == true)
        // If selected, activate the object; otherwise, deactivate it.
        if (isOn)
        {
            cube.SetActive(true);
        }
        if (isOn == false)
        {
            cube.SetActive(false);
        }
    }

    public void OnToggleSphere(bool isOn)
    {
        // Check if the toggle is selected (isOn == true)
        // If selected, activate the object; otherwise, deactivate it.
        if (isOn)
        {
            sphere.SetActive(true);
        }
        if (isOn == false)
        {
            sphere.SetActive(false);
        }
    }

    public void OnToggleCylinder(bool isOn)
    {
        // Check if the toggle is selected (isOn == true)
        // If selected, activate the object; otherwise, deactivate it.
        if (isOn)
        {
            cylinder.SetActive(true);
        }
        if (isOn == false)
        {
            cylinder.SetActive(false);
        }
    }
}