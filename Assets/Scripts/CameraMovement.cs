using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    private Camera mainCamera;
    private float RotationX = 0f;
    private float RotationY = 0f;

    void Start()
    {
        mainCamera = Camera.main;    
    }

    void Update()
    {
        RotationX -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        RotationY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        mainCamera.transform.localRotation = Quaternion.Euler(RotationX, RotationY, 0); 
    }
}
