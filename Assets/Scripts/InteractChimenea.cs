using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractChimenea : MonoBehaviour
{
    public void Interact()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public string GetDescription()
    {
        return "E to interact";
    }
}
