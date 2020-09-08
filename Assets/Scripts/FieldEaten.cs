using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldEaten : MonoBehaviour
{
    [SerializeField]
    public GameObject fightprefab;
    [SerializeField]
    public GameObject fightPos;

    AudioSource eatSound;
    // Start is called before the first frame update
    void Start()
    {
        eatSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(true )
        {
            //eatSound.Play();
            //GameObject fightcloud = Instantiate(fightprefab, transform.position, transform.localRotation);
            //Destroy(fightcloud, 3f);
            //Destroy(gameObject);
            Debug.Log("entered");
        }

    }

 
}
