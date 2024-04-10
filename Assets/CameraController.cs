using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 100f;
    public float maxYAngle = 90f;
    public float moveSpeed = 5f;


    public Transform playerTransform; // ������ ������
    private CharacterController playerController;
    private float rotationX = 0f;

    void Start()
    {
        // �������� CharacterController �� �������� �������� playerTransform
        playerController = playerTransform.GetComponentInChildren<CharacterController>();
    }

    void Update()
    {

        // ���������� �������
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        playerTransform.Rotate(Vector3.up * mouseX);

        // ���������� �������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = playerTransform.forward * verticalInput + playerTransform.right * horizontalInput;

        // ��������� �������� � ������ � ������� CharacterController
        playerController.Move(moveDirection * moveSpeed * Time.deltaTime);
        

    }

}
