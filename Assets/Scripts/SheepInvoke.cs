using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepInvoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameCode.instance.cropeaten == true)
        {
            gameObject.GetComponent<SheepMovememt>().enabled = true;
            GameCode.instance.gameHasEnded = true;
        }
    }
}
