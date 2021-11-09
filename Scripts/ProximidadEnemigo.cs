using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximidadEnemigo : MonoBehaviour
{
    Animator animacion;
    GameObject barril;
    float umbral = 3f;
    
    void Start()
    {
        animacion = GetComponent<Animator>();
        barril = GameObject.FindWithTag("Barril");
    }

    void Update()
    {
        if ((transform.position - barril.transform.position).magnitude < umbral)
        {
            Debug.Log("Entrando");
            animacion.SetBool("Morir", true);
        }
        else
        {
            animacion.SetBool("Morir", false);
        }
    }
}
