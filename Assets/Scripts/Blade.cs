using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    [SerializeField]
    public GameObject bladeTrailPrefab;

    [SerializeField]
    public float minCuttingVelocity = 1.0f;

    bool isCutting = false;

    Vector2 prevPos;

    GameObject currentBladeTrail;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            StopCuttting();
        }

        if(isCutting)
        {
            UpdateCut();
        }
    }

    void StartCutting()
    {
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        circleCollider.enabled = false;
        prevPos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void StopCuttting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 2.0f);
        circleCollider.enabled = false;
    }

    void UpdateCut()
    {

        Vector2 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPos;

        float velocity = (newPos - prevPos).magnitude / Time.deltaTime;

        prevPos = newPos;

        if(velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }
    }


}
