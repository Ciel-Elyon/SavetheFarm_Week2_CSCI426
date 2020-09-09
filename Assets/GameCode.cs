using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameCode : MonoBehaviour
{
    [SerializeField]
    private float sheepdecaySpeed = -2.0f;
    [SerializeField]
    private float wolfdecaySpeed = -3.0f;

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

        if(sheepScore <= 0)
        {
            cropeaten = true;
        }

        if(wolfScore <= 0)
        {
            sheepeaten= true;
        }

        if (gameHasEnded)
            EndGame();

    }

    void EndGame()
    {
        if(gameHasEnded ==  false)
        {
            gameHasEnded = true;
            
            //reset variables
            cropScore = 0.0f;
            sheepScore = 33f;
            wolfScore = 50.0f;
            cropeaten = false;
            sheepeaten = false;
            gameHasEnded = false;

            ReturnToMenu("Menu");
        }
    }

    void ReturnToMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
