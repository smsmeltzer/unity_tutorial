using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 myStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        myStartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = GetComponent<Rigidbody>().velocity.x;
        float y = GetComponent<Rigidbody>().velocity.y;
        float z = GetComponent<Rigidbody>().velocity.z;

        if(Input.GetKeyDown("space") && (GetComponent<Rigidbody>().velocity.y == 0))
        {
            y = 5;
        }

        if (Input.GetKey("up"))
        {
            z = 5;
        }


        if (Input.GetKey("down"))
        {
            z = -5;
        }

        if (Input.GetKey("left"))
        {
            x = -5;
        }

        if (Input.GetKey("right"))
        {
            x = 5;
        }

        if (Input.GetKey("r"))
        {
            transform.position = myStartPosition;
            x = 0;
            y = 0;
            z = 0;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(x, y, z);
    }
}