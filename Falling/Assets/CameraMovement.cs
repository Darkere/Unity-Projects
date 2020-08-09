using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    public int Target;
    private int stage = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(this.transform.position.y < Target)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + Speed, this.transform.position.z);
        }
        float delta = this.transform.position.y / Target;
        delta *= 10;
// Debug.Log(delta);
        if (delta > stage)
        {
            stage++;
            Speed += 0.05f;
          //  Debug.Log("Speed UP");
        }
        
    }
}
