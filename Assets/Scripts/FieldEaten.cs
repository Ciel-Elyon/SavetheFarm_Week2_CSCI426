using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldEaten : MonoBehaviour
{
    [SerializeField]
    public GameObject fightprefab;

    AudioSource eatSound;
    // Start is called before the first frame update
    void Start()
    {
        eatSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Blade"))
        {
            eatSound.Play();
            fightprefab.SetActive(true);
            Destroy(gameObject, 2f);
        }

    }

 
}
