using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watrerdrop : MonoBehaviour
{
    [SerializeField]
    public GameObject waterParticlePrefab;


    public int index;
    Rigidbody2D rb;
    bool isSheep = false;
    bool isWolf = false;
    bool isCrop = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SheepCheck")
        {
            isSheep = true;
           
        }
        else if(other.tag == "CropCheck")
        {
            isCrop = true;
           
        }
        else if(other.tag == "WolfCheck")
        {
            isWolf = true;
   
        }
        if(other.tag == "Blade")
        {
            if(isSheep)
            {
                if(gameObject.tag == "Water")
                {
                    GameCode.instance.sheepScore += 5.0f;
                }
                else if(gameObject.tag == "Meat")
                {
                    GameCode.instance.sheepScore -= 8.0f;
                }
                else if(gameObject.tag == "Hay")
                {
                    GameCode.instance.sheepScore += 10.0f;
                }
            }
            else if (isWolf)
            {
                if (gameObject.tag == "Water")
                {
                    GameCode.instance.wolfScore += 5.0f;
                }
                else if (gameObject.tag == "Hay")
                {
                    GameCode.instance.wolfScore -= 8.0f;
                }
                else if (gameObject.tag == "Meat")
                {
                    GameCode.instance.wolfScore += 10.0f;
                }
            }
            else if (isCrop)
            {
                if (gameObject.tag == "Water")
                {
                    GameCode.instance.cropScore += 8.0f;
                }
                else if (gameObject.tag == "Meat")
                {
                    GameCode.instance.cropScore -= 8.0f;
                }
                else if (gameObject.tag == "Hay")
                {
                    GameCode.instance.cropScore -= 8.0f;
                }
            }
            GameObject particle = Instantiate(waterParticlePrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
