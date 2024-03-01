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
        if (saveData != null)
        {
            StartCoroutine(LoadSceneAfterFrame(saveData.currentScene, new Vector3(saveData.positions[0].x, saveData.positions[0].y, saveData.positions[0].z)));
            Debug.Log("Has cargado tu partida");
        }
    }

    private IEnumerator LoadSceneAfterFrame(string sceneName, Vector3 position)
    {
        yield return null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        transform.position = position;
    }


    public void PlayButton()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void Cinematica()
    {
        SceneManager.LoadSceneAsync("Cinematica");
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }
}