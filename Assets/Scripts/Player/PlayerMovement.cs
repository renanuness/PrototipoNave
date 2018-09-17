using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveForward();
        }

        if (Input.GetKey(KeyCode.W))
        {
            RotateUp();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            RotateDown();
        }

        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }
    }

    private void MoveForward()
    {
        transform.position += transform.forward * 15 * Time.deltaTime;
    }

    private void RotateUp()
    { 
        transform.Rotate(new Vector3(30 * Time.deltaTime, 0, 0));
    }

    private void RotateDown()
    {
        transform.Rotate(-30  * Time.deltaTime, 0, 0);
    }

    private void RotateLeft()
    {
        transform.Rotate(0,0,35 * Time.deltaTime);
    }

    private void RotateRight()
    {
        transform.Rotate(0, 0, -35 * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.forward,Color.red, 1f);
        Debug.DrawRay(transform.position, new Vector3(0,0,1),Color.red, 1f);
    }
}
