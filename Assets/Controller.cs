using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //***Public Variables***//
    public float moveSpeed = 3.0f;
    public float gravity = 9.81f;

    //**Private variables**//
    private CharacterController myController;

    // Start is called before the first frame update
    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        //To determine the movement in the z-direction
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;

        //To determine the movement in the x-direction
        Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

        //Convert combined Vector3
        Vector3 movement = transform.TransformDirection(movementZ + movementX);

        //Apply gravity
        movement.y -= gravity * Time.deltaTime;
        
        //Debug.Log ("Movement Vector =" + movement);
        myController.Move(movement);
    }
}
