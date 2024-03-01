using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void InicializarDesdeBoton()
    {
        Inicializar();
    }

    private void Inicializar()
    {
        SaveData saveData = SaveManager.LoadGameState();

        if (saveData == null)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void Cinematica()
    {
        SceneManager.LoadSceneAsync("Cinematica");
    }
}
