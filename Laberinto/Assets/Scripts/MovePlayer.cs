using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    Transform rotacionPlayer;
    Rigidbody playerRgdby;
    Transform playerTransform;
    public GameObject Kid;
    float rotateInX;
    float rotateInY;


    private void Awake()
    {
        playerRgdby = GetComponent<Rigidbody>();
        playerTransform = transform;
    }
  
    // Update is called once per frame
    void Update()
    {
        displacement();
        MoveCamera();
    }

    public void displacement() // Función que contiene los atributos de movimiento de personaje que emplea el heroe.
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(transform.forward.x, 0, transform.forward.z) * 2.3f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(transform.forward.x, 0, transform.forward.z) * 2.3f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 2.3f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 2.3f * Time.deltaTime;
        }
    }

    void MoveCamera()
    {
        rotateInX += Input.GetAxis("Mouse X");
        rotateInY += Input.GetAxis("Mouse Y");

        if(rotateInY>10)
        {
            rotateInY--;
            if (rotateInY == 0)
            {
                rotateInY = 0;
            }
        }
        if (rotateInY < -10)
        {
            rotateInY++;
            if (rotateInY == 0)
            {
                rotateInY = 0;
            }
        }
        Kid.transform.eulerAngles = new Vector3(rotateInY*2, rotateInX * 2, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<IInteractable>() != null)
        {
            other.GetComponentInParent<IInteractable>().Interact();
        }
    }
}