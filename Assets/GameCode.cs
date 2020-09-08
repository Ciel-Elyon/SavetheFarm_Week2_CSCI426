using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCode : MonoBehaviour
{
    [SerializeField]
    public float cropScore = 0.0f;
    [SerializeField]
    public float sheepScore = 33.3f;
    [SerializeField]
    public float wolfScore = 50.0f;

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

    private void Start()
    {
        
    }
}
