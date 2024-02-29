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
                // Llama a la funci�n Ganar() en GanarScript
                ganarScript.Ganar();

                // Activa el pop-up despu�s de que se haya completado la funci�n Ganar()
                GameObject popup = GameObject.Find("MediaNota"); // Aseg�rate de reemplazar "NombreDelPopUp" con el nombre real del pop-up
                if (popup != null)
                {
                    popup.SetActive(true);
                }
                else
                {
                    Debug.LogError("El pop-up no se encontr� en la escena.");
                }
            }
            else
            {
                Debug.LogError("No se encontr� el script GanarScript en la escena actual.");
            }
        }
    }
}
