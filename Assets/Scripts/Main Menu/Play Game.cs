using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton()
    {
        SceneManager.LoadSceneAsync("SampleScene");

    }

    public void Cinematica()
    {
        SceneManager.LoadSceneAsync("Cinematica");
    }
}
