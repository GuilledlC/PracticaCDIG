using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamara : MonoBehaviour
{
    float rotationX = 0;

    [Header("Camera Settings")]
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 90.0f;

    [HideInInspector]
    float mouseX;
    float mouseY;
    void Start()
    {
        //Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        PlayerInput();

        Rotation();
    }

    private void PlayerInput()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }

    private void Rotation()
    {
        //Player rotation
        rotationX += -mouseY * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
        transform.rotation *= Quaternion.Euler(0, mouseX * lookSpeed, 0);

        //Camera rotation
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
