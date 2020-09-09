using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepEaten : MonoBehaviour
{
    [SerializeField]
    public GameObject fightprefab;


    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Eater"))
        {
            GameObject fightcloud = Instantiate(fightprefab, transform.position, transform.localRotation);
            Destroy(fightcloud, 3f);
            Destroy(gameObject);
        }

    }
}
