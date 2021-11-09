using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionEnemigo : MonoBehaviour
{
    Animator animacion;

    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("x"))
        {
            animacion.SetBool("Animacion", true);
        }
        else
        {
            animacion.SetBool("Animacion", false);
        }
    }
}
