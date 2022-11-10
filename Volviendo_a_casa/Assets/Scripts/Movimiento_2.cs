using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_2 : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 30f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * x + Physics.gravity + transform.forward * z;
        controller.Move(movimiento * speed * Time.deltaTime);
    }
}
