using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntreEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {

        var noDestruirEntreEscenas = FindObjectsOfType<EntreEscenas>();
        if(noDestruirEntreEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
