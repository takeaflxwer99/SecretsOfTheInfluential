using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prueba : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public string GetDescription()
    {
        return "si";
    }
}
