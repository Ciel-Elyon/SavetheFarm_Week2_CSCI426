using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestory : MonoBehaviour
{
    public static NoDestory instance;

    private void Awake()
    {
        if(instance != null)
        {
            GameObject.Destroy(instance);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
}
