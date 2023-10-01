using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float rotationSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Camera movement
        float horizontalInput = Input.GetKey("d") ? 1.0f : Input.GetKey("a") ? -1.0f : 0.0f;
        float verticalInput = Input.GetKey("w") ? 1.0f : Input.GetKey("s") ? -1.0f : 0.0f;

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Camera rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotation = new Vector3(-mouseY, mouseX, 0.0f) * rotationSpeed;
        transform.eulerAngles += rotation;
    }
}
