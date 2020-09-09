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

    public GameObject wintext;
    public GameObject losetext;
    public GameObject instructions;

    public GameObject restartButton;
    public GameObject startButton;

    public Slider plantSlider;
    public Slider sheepSlider;
    public Slider wolvesSlider;

    public float cropScore = 0.0f;
    public float sheepScore = 33f;
    public float wolfScore = 50.0f;

    public bool gameHasEnded = false;
    public bool gameHasWon = false;
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
        Time.timeScale = 0f;
    }

    void Update() {

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

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

        if (cropScore >= 100 && sheepScore >= 100)
            wintext.SetActive(true);
        else if (gameHasEnded)
            losetext.SetActive(true);


    }

   public void ReturnToMenu()
    {
        //reset variables
        cropScore = 0.0f;
        sheepScore = 33f;
        wolfScore = 50.0f;
        cropeaten = false;
        sheepeaten = false;
        gameHasEnded = false;
        gameHasWon = false;
        Time.timeScale = 0f;
        startButton.SetActive(true);
        instructions.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1.0f;
        instructions.SetActive(false);
        startButton.SetActive(false);
    }
}
