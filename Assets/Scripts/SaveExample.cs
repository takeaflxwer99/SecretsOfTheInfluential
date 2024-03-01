using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveExample : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
            SaveGame();
        if (Input.GetKeyUp(KeyCode.L))
            LoadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData();
        saveData.positions = new SaveData.Position[1];
        saveData.positions[0] = new SaveData.Position();
        saveData.positions[0].x = transform.position.x;
        saveData.positions[0].y = transform.position.y;
        saveData.positions[0].z = transform.position.z;

        saveData.currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        SaveManager.SaveGameState(saveData);

        Debug.Log("Has guardado");
    }

    public void LoadGame()
    {
        SaveData saveData = SaveManager.LoadGameState();
        if (saveData != null)
        {
    
            transform.position = new Vector3(saveData.positions[0].x, saveData.positions[0].y, saveData.positions[0].z);

            UnityEngine.SceneManagement.SceneManager.LoadScene(saveData.currentScene);

            Debug.Log("Has cargado tu partida");
        }
    }

}
