using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private float xRotation= 0.0f;
    private float rotationX = 0f;
public float mouseSensivity = 1000f;
public Transform xPos ;
public GameObject player ; 
public GameObject pivot ; 
    // Update is called once per frame

    private void Awake() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        float mouseXY = Input.GetAxis("Mouse X");
        rotationX -= mouseXY * mouseSensivity;
        rotationX = Mathf.Clamp(rotationX, -40f, 40f);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -10f, 30f);


        transform.localRotation = Quaternion.Euler(xRotation,0,0);

        pivot.transform.Rotate(Vector3.up*mouseX);
        
    }
}
