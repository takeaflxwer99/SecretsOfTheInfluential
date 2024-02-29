using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzlecompletado : MonoBehaviour
{
    public DragandDrop[] objetos;
    public GameObject[] siluetas;
    public float distancia;
    public GameObject popup;

    private bool Juegoterminado = false;
    private Vector2[] objetosEnPosicionInicial;

    void Start()
    {
        objetosEnPosicionInicial = new Vector2[objetos.Length];
        for (int i = 0; i < objetos.Length; i++)
        {
            objetosEnPosicionInicial[i] = objetos[i].transform.position;
        }
        
    }

    void Update()
    { if (!Juegoterminado)
        {  // Verificar si todos los objetos están en la posición correcta
            bool todosBloqueados = true;
            foreach (DragandDrop bloqueado in objetos)
            {
                if (!bloqueado.establoqueado)
                {
                    todosBloqueados = false;
                    break;
                }
            }

            if (todosBloqueados)
            {
                Ganar();
            }
        }
    }

    public void Ganar()
    {
        Juegoterminado = true;
        popup.SetActive(true); 
       StartCoroutine (SpawnDelay());
    }
    public IEnumerator SpawnDelay()
    { 
            yield return new WaitForSeconds(10);
        PlayerPrefs.SetInt("JuegoTerminado", Juegoterminado ? 1 : 0);
        SceneManager.LoadSceneAsync("SampleScene");}
  

    // Método para comprobar si todos los objetos están en la posición correcta
    //public void ComprobarPosiciones()
    //{
    //    for (int i = 0; i < objetos.Length; i++)
    //    {
    //        float distanciaMinima = Vector3.Distance(objetos[i].transform.position, siluetas[i].transform.position);
    //        if (distanciaMinima < distancia)
    //        {
    //            objetosBloqueados[i] = true;
    //            objetos[i].transform.position = siluetas[i].transform.position;
    //        }
    //        else
    //        {
    //            objetos[i].transform.position = objetosEnPosicionInicial[i];
    //        }
    //    }
    //}
}
