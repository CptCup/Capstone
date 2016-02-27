using UnityEngine;
using System.Collections;

public class Player : Entities {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
