using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript: MonoBehaviour
{
    // Start is called before the first frame update
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    void Start()
    {
        up = true;
        down = true;
        left = true;
        right = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 nextPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        nextPosition.z = 0;
        if(!up && nextPosition.y > this.transform.position.y)
        {
            nextPosition.y = this.transform.position.y;
        }
        else if(!down && nextPosition.y < this.transform.position.y)
        {
            nextPosition.y = this.transform.position.y;
        }
        else if(!left && nextPosition.x < this.transform.position.x)
        {
            nextPosition.x = this.transform.position.x;
        }
        else if (!right && nextPosition.x > this.transform.position.x)
        {
            nextPosition.x = this.transform.position.x;
        }
       // Debug.Log(up + " " + left + " " + right + " " + down);
        this.transform.position = nextPosition;
    }
}
