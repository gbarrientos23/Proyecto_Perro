using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danio_auto : MonoBehaviour
{
    public int damage;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player.GetComponent<Vida_perro>().vidaPlayer -= damage;
        }

        if (other.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }
}