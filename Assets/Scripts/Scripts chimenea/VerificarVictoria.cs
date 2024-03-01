using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VerificarVictoria : MonoBehaviour
{
    public TextMeshProUGUI mensajeVictoria;

    void Start()
    {
        // Asegurarse de que al iniciar el juego, el valor de "JuegoTerminado" sea 0
        if (!PlayerPrefs.HasKey("JuegoTerminado"))
        {
         
            PlayerPrefs.SetInt("JuegoTerminado", 0);
        }

        // Verificar si el juego ha terminado en la escena anterior
        bool juegoTerminado = PlayerPrefs.GetInt("JuegoTerminado") == 1;

        if (juegoTerminado)
        {
            Debug.Log("¡Has ganado la partida en la escena anterior!");

            // Aquí puedes realizar las acciones necesarias cuando has ganado, como activar objetos, reproducir sonidos, etc.
            if (mensajeVictoria != null)
            {
                mensajeVictoria.gameObject.SetActive(true);
                mensajeVictoria.text = "¡Gracias por jugar nuestra DEMO!";
            }
        }
        else
        {
            mensajeVictoria.gameObject.SetActive(false);
            Debug.Log("El juego aún no ha terminado.");
        }

        // Puedes restablecer la clave PlayerPrefs si es necesario
        // PlayerPrefs.SetInt("JuegoTerminado", 0);
    }
}
