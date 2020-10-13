using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    /*
    tutotial https://unitytutoriais.wordpress.com/2016/02/08/visao-em-primeira-pessoa-no-unity/
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");
    float sensitivity = 60f;

    float movementY = mouseY * sensitivity * Time.deltaTime;

    float newAngleY = transform.eulerAngles.x + movementY;
    transform.Rotate(0f, mouseX* sensitivity * Time.deltaTime, 0f, Space.World);

        if (newAngleY <= 20 || newAngleY >= 270)
        {
            transform.Rotate(movementY, 0f, 0f);
        }
    */

    [SerializeField] private float cameraSensitivity = 100f;
    [SerializeField] private float minimumAngle = -60f, maximumAngle = 60f;
    [SerializeField] private float rotation = 0f;
    public Transform transformPlayer;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;

        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, minimumAngle, maximumAngle);

        transform.localRotation = Quaternion.Euler(rotation, 0, 0);

        transformPlayer.Rotate(Vector3.up * mouseX);
    }
}
