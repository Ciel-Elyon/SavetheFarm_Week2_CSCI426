using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameCode : MonoBehaviour
{

    public Slider plantSlider;
    public Slider sheepSlider;
    public Slider wolvesSlider;

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

    void Update() {
        plantSlider.value = cropScore/100; 
        sheepSlider.value = sheepScore/100;
        wolvesSlider.value = wolfScore/100;
    }
}
