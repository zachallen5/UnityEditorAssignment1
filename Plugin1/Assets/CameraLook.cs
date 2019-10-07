using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    private float rotX = 0;
    private float rotY = 0;
    public GameObject player;

    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {

        }
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        rotY += mouseX * sensitivity * Time.deltaTime;
        rotX += mouseY * sensitivity * Time.deltaTime;
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        Quaternion localPlayerRot = Quaternion.Euler(0.0f, rotY, 0.0f);
        transform.rotation = localRotation;
        player.transform.localRotation = localPlayerRot;

    }
}
