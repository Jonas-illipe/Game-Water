using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int moveSpeed = 10;
    public Rigidbody2D rb;
    Vector2 angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle.x = Input.GetAxis("Horizontal");
        angle.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + angle * moveSpeed * Time.fixedDeltaTime);
    }
}