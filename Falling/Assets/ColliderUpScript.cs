using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderUpScript : MonoBehaviour
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
        this.GetComponentInParent<PlayerMoveScript>().up = false;
    }
    private void OnTriggerExit(Collider collision)
    {
        this.GetComponentInParent<PlayerMoveScript>().up = true;
    }
}
