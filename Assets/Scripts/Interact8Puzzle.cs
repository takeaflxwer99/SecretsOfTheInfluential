using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact8Puzzle : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public string GetDescription()
    {
        return "E to interact";
    }
}
