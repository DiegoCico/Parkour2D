using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject player;
    public float interpSpeed; // speed of the camera following sprite
    public Vector3 tagetpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tagetpos = new Vector3(player.transform.position.x, player.transform.position.y + 2, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, tagetpos, interpSpeed);
    }
}
