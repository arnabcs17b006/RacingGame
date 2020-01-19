using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rb;
    //public GameObject rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(0, moveSpeed * Time.fixedDeltaTime * -1);
    }
    
}
