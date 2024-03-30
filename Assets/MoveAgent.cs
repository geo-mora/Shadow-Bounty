using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgent : MonoBehaviour
{
	public float speed = .1f;
	
    // Start is called before the first frame update
	// Void Start not needed since we want to move object the entire time
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
		float zDirection = Input.GetAxis("Vertical");
		
		Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
		
		transform.position += moveDirection * speed;
    }
}
