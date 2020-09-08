using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareCrowMovement : MonoBehaviour
{
    [SerializeField] public float speed;
    private Rigidbody2D myrigidbody;
    private Vector3 mousechange;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mousechange = Vector2.zero;
        mousechange.x = Input.GetAxisRaw("Horizontal");
        mousechange.y = Input.GetAxisRaw("Vertical");
       
        if(mousechange != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        myrigidbody.MovePosition(transform.position + mousechange.normalized * speed * Time.deltaTime);
    }
}
