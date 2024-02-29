using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
   public void LogDebugMessages(string messageToLog,object sender,bool canLog)
    {
        if (canLog)
        {
            Debug.Log(messageToLog + " :From: "+ sender.ToString());
        }
    }
}
