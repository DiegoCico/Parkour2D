using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float forceUp = 10f; //adding force to go up

    public bool isTouchingFloor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump(); //jumping loop

        //moving left right
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f );
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isTouchingFloor == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceUp), ForceMode2D.Impulse);
        }
        //forcemode2d is the type of force added
        // adding a force up to make the character jump
    }
}
