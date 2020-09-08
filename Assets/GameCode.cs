using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCode : MonoBehaviour
{
    [SerializeField]
    private float cropScore = 0.0f;
    [SerializeField]
    private float sheepScore = 33.3f;
    [SerializeField]
    private float wolfScore = 50.0f;

    public static GameCode instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = null;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
}
