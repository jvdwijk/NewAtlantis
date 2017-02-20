using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour {

    private Vector2 rotation;
    private Vector2 currentRotation;
    private Vector2 rotationVelocity;
    private float lookSensetivity = 5;
    private float lookSmoothDamp = 0.1f;

    private Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = this.transform.parent.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rotation.x -= Input.GetAxis("Mouse Y") * lookSensetivity;
        rotation.y += Input.GetAxis("Mouse X") * lookSensetivity;

        rotation.x = Mathf.Clamp(rotation.x, -90, 90);

        currentRotation.x = Mathf.SmoothDamp(currentRotation.x, rotation.x, ref rotationVelocity.x, lookSmoothDamp);
        currentRotation.y = Mathf.SmoothDamp(currentRotation.y, rotation.y, ref rotationVelocity.y, lookSmoothDamp);

        transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, 0);

        rigidBody.MoveRotation(Quaternion.Euler(0, currentRotation.y, 0));
    }
}
