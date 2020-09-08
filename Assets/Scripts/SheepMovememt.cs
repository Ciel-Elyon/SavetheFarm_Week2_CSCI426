using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using TreeEditor;

public class SheepMovememt : MonoBehaviour
{
    [SerializeField]
    public PathCreator pathCreator;
    [SerializeField]
    public float speed = 5;
    [SerializeField]
    public EndOfPathInstruction end;

    AudioSource hungrysound;

    float distanceTravelled;

    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        hungrysound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            hungrysound.enabled = true;
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, end);
        }
        
    }
}
