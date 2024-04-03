using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    GameObject player;

    public bool floor = false; //checking if you touched the ground or not 

    // Start is called before the first frame update
    void Start()
    {
        //getting the parent to be the character receiving the code
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //getting the name of the tag and checking if you are touching the ground
        if (collision.collider.tag == "Floor") {
            floor = true;   
            player.GetComponent<Movement>().isTouchingFloor = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor") {
            floor = false;
            player.GetComponent<Movement>().isTouchingFloor = false;
        }
    }
}
