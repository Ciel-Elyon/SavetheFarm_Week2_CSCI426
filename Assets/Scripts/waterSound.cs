using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterSound : MonoBehaviour
{
    AudioSource waterS;
    // Start is called before the first frame update
    void Start()
    {
        waterS = GetComponent<AudioSource>();
        waterS.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
