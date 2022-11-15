using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transiciones : MonoBehaviour
{
    public float velocidadMovimiento = 10.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        if (Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
            anim.SetBool("semueve", true);
        }
        if (!Input.GetKeyDown("up") && !Input.GetKeyDown("down"))
        {
            anim.SetBool("semueve", false);
        }
    }
}