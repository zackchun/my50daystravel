using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    CharacterController character;
    public float speed = 4f;
    public float rotateSpeed = 0.01f;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {

        float rotation = (Input.mousePosition.x - Screen.width / 2) / Screen.width;
        float rotation2 = (Input.mousePosition.y - Screen.height / 2) / Screen.height;

        if (rotation > 0.2f || rotation < -0.2f)  
        {
            transform.Rotate(0, rotation * rotateSpeed, 0);
        }

        else if (rotation2 > 0.2f || rotation2 < -0.2f)  
        {
            transform.Rotate(-rotation2 * rotateSpeed, 0, 0);
        }
    

        Vector3 forward = transform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical");
        Vector3 sidestep = transform.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal");
        Vector3 direction = forward + sidestep;
        character.Move(direction * Time.deltaTime * speed);

    }
}
