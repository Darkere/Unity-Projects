using UnityEngine;
using System.Collections;

public class Rotate: MonoBehaviour
{
	public float speed = 10f;
	public float  thrust;
	public  Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(0,speed* Input.GetAxis ("Mouse X"),0);
		transform.Rotate(speed* Input.GetAxis ("Mouse Y"),0,0);
		//tr.rotation.y = tr.rotation + 10 * Input.GetAxis ("Mouse Y");#

		
	}
		void FixedUpdate ()	{
			if(Input.GetMouseButton(0)){
			rb.AddRelativeForce(Vector3.forward * thrust);

			}

		if(Input.GetMouseButton(1)){
			rb.AddRelativeForce(Vector3.up * thrust);
			
		}

		new WaitForSeconds(3);
	}
}
 