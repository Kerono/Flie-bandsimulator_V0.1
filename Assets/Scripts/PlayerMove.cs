using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [SerializeField] private string horizontalInputName, verticalInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>(); 
    }
    private void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis(horizontalInputName) * movementSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis(verticalInputName) * movementSpeed * Time.deltaTime;

        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 sideMovement = transform.right * horizontalInput;

        characterController.SimpleMove(forwardMovement + sideMovement);
    }

}
