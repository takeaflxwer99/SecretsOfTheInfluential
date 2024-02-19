using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Transform objetivoASeguir;
    private float distanciaObjetivoX = 0f;
    private float velocidadCamara = 15f;
    public bool suavizadoActivado = false;
    private Vector3 nuevaPosicion;
    // Update is called once per frame
    void Update()
    {
        nuevaPosicion = this.transform.position;
        nuevaPosicion.x = objetivoASeguir.transform.position.x - distanciaObjetivoX;
        nuevaPosicion.z = objetivoASeguir.transform.position.z;
        if (suavizadoActivado)
        {
            this.transform.position =
                Vector3.Lerp(this.transform.position, nuevaPosicion, velocidadCamara * Time.deltaTime);
        }
        else
        {
            this.transform.position = nuevaPosicion;
        }
    }
}
