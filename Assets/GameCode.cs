using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameCode : MonoBehaviour
{
    [SerializeField]
    private float sheepdecaySpeed = -3.0f;
    [SerializeField]
    private float wolfdecaySpeed = -4.0f;

    public Slider plantSlider;
    public Slider sheepSlider;
    public Slider wolvesSlider;

    public float cropScore = 0.0f;
    public float sheepScore = 33f;
    public float wolfScore = 50.0f;

    public bool gameHasEnded = false;
    public bool cropeaten = false;
    public bool sheepeaten = false;

    public static GameCode instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    private void Start()
    {
        gameHasEnded = false;
    }

    void Update() {
        plantSlider.value = cropScore/100; 
        sheepSlider.value = sheepScore/100;
        wolvesSlider.value = wolfScore/100;

        sheepScore += (sheepdecaySpeed * Time.deltaTime);
        wolfScore += (wolfdecaySpeed * Time.deltaTime);

    }

    void EndGame()
    {
        if(gameHasEnded ==  false)
        {
            gameHasEnded = true;
            ReturnToMenu("Menu");
        }
    }

    void ReturnToMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
