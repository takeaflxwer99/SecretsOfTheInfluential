using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventariomanager : MonoBehaviour
{
    private void AlgunaFuncion()
    {
        int juegoTerminado = PlayerPrefs.GetInt("JuegoTerminado", 0);
        if (juegoTerminado == 1)
        {
            // Encuentra el objeto con el script GanarScript
            Puzzlecompletado ganarScript = FindObjectOfType<Puzzlecompletado>();
            if (ganarScript != null)
            {
                // Llama a la función Ganar() en GanarScript
                ganarScript.Ganar();

                // Activa el pop-up después de que se haya completado la función Ganar()
                GameObject popup = GameObject.Find("MediaNota"); // Asegúrate de reemplazar "NombreDelPopUp" con el nombre real del pop-up
                if (popup != null)
                {
                    popup.SetActive(true);
                }
                else
                {
                    Debug.LogError("El pop-up no se encontró en la escena.");
                }
            }
            else
            {
                Debug.LogError("No se encontró el script GanarScript en la escena actual.");
            }
        }
    }
}
