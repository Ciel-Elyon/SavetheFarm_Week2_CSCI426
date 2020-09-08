using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watrerdrop : MonoBehaviour
{
    [SerializeField]
    public GameObject waterParticlePrefab;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Blade")
        {
            GameObject particle = Instantiate(waterParticlePrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
