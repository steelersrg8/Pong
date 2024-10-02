using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls: MonoBehaviour
{

    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
  

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(moveUp))
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.y = 6.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }
        else if (Input.GetKeyDown(moveDown))
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.y = -6.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }

        else if (!Input.anyKey)
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.y = 0.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }

    }
}