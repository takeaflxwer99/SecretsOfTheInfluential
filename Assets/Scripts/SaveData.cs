using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public Position[] positions;
    public string currentScene;

    [System.Serializable]
    public class Position
    {
        public float x;
        public float y;
        public float z;
    }
}
