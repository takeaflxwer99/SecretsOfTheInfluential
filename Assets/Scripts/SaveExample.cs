using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveExample : MonoBehaviour
{
 
    private void SaveGame()
    {

        SaveData saveData = new SaveData();
        saveData.positions = new SaveData.Position[1];
        saveData.positions[0] = new SaveData.Position();
        saveData.positions[0].x = transform.position.x;
        saveData.positions[0].y= transform.position.y;
        saveData.positions[0].z = transform.position.z;
        SaveManager.SaveGameState(saveData);
    }

    private void LoadGame()
    {
        SaveData saveData = SaveManager.LoadGameState();
        if(saveData != null)
        {
            transform.position=new Vector3(saveData.positions[0].x, saveData.positions[0].y, saveData.positions[0].z);

        }

        

    }

}
