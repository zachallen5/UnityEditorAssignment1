using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    public float moveSpeed;
    private Vector3 movement;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity;

        //MOVEMENT
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vertical = 1f;
            
            //Vector3 playerPosition = transform.position;
            //playerPosition.x += 0.1f;
            //transform.position = playerPosition;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vertical = -1f;
            //Vector3 playerPosition = transform.position;
            //playerPosition.x -= 0.1f;
            //transform.position = playerPosition;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            horizontal = -1f;
            //Vector3 playerPosition = transform.position;
            //playerPosition.z += 0.1f;
            //transform.position = playerPosition;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            horizontal = 1f;
            //Vector3 playerPosition = transform.position;
            //playerPosition.z -= 0.1f;
            //transform.position = playerPosition;
        }




        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            vertical = 0f;


        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            vertical = 0f;
 
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            horizontal = 0f;

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            horizontal = 0f;

        }
        movement = new Vector3(horizontal * moveSpeed * Time.deltaTime, 0, vertical * moveSpeed * Time.deltaTime); movement = transform.TransformDirection(movement);

        rigidbody.MovePosition(transform.position + (transform.forward * movement.z) + (transform.right * movement.x));
    }
}
