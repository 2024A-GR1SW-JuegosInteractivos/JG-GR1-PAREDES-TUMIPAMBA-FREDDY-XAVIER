using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEjemplo : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other){
            Debug.Log("Ouch");
    }

/*
    void OnTriggerEnter2D(Collider2D other){
            Debug.Log("Entrando En trigger");
    }
*/
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando en trigger! " );
        if (other.tag == "Paquete")
        {
            Debug.Log("Recogio paquete");
        }

        if (other.tag == "Cliente")
        {   
            Debug.Log("Dejo paquete");
        }
    }
}