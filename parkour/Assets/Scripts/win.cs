using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{

    public Vector3 winTp;
    public GameObject winG;
    public GameObject winFloor;
    public GameObject winKey;

    public Vector3 playerPos;
    public GameObject player;

    public bool gotKey = false;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.transform.position;
        winTp = winG.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotKey == true) {
            Destroy(winFloor);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "win") {
            player.transform.position = winG.transform.position;
        }
        if (collision.collider.tag == "key") {
            gotKey = true;
        }
    }
}
