using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 10f;
    Rigidbody2D rigid;
    float dirH;
    float dirV;


    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
		
	}
    private void Update()
    {
         dirH = Input.GetAxis("Horizontal");
         dirV = Input.GetAxis("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate () {

        rigid.velocity = new Vector2(dirH * speed, rigid.velocity.y);
       
        rigid.velocity = new Vector2(rigid.velocity.x,dirV * speed );

    }
}
