using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    public GameObject objeto;
    public GameObject silueta;
    public float distancia;
    public bool establoqueado;

    Vector2 Objetoenposicion;

    // Start is called before the first frame update
    void Start()
    {
        Objetoenposicion = objeto.transform.position;
    }

   public void ArrastrarObjeto()
    {
        if (!establoqueado)
        { objeto.transform.position = Input.mousePosition; }
       }        
     public void SoltarObjeto()
    {

        float Distance = Vector3.Distance(objeto.transform.position, silueta.transform.position);
        if(Distance < distancia)
        { establoqueado = true;
            objeto.transform.position = silueta.transform.position;
        }
        else
        { objeto.transform.position = Objetoenposicion; }
    }
                
             
}
