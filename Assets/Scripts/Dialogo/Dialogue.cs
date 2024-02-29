using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Dialogue
{
    public string npcName;

    [TextArea(3, 10)]
    public string[] dialogueSentences;

    public Sprite characterImage;
}

