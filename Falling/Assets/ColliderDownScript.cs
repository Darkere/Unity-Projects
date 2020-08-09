using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDownScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        this.GetComponentInParent<PlayerMoveScript>().down = false;
    }
    private void OnTriggerExit(Collider collision)
    {
        this.GetComponentInParent<PlayerMoveScript>().down = true;
    }
}
