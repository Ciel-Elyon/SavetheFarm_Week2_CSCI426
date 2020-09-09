﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightshake : MonoBehaviour
{
    [SerializeField]
    private float amount = 10.0f; // how much the item shakes

    bool shaking = false;

    AudioSource eatsound;

    // Start is called before the first frame update
    void Start()
    {
        eatsound = GetComponent<AudioSource>();
    }

    private void Update()
    {
       if(shaking)
        {
            eatsound.Play();
            Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * amount);
            newPos.y = transform.position.y;
            newPos.z = transform.position.z;

            transform.position = newPos;
       }
        ShakeMe();
    }

    public void ShakeMe()
    {
        StartCoroutine(ShakeNow());
    }

    IEnumerator ShakeNow()
    {
        Vector3 originalPos = transform.position;

        if(shaking == false)
        {
            shaking = true;
        }

        yield return new WaitForSeconds(.75f);

        shaking = false;
        transform.position = originalPos;
    }
   
}