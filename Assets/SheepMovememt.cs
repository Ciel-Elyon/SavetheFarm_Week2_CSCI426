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

    float distanceTravelled;

    bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, end);
        }
        
    }
}
