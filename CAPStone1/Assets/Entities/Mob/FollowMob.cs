using UnityEngine;
using System.Collections;

public class FollowMob : Entities {

    public Entities follow;
    public float dist; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(follow.GetComponent<Rigidbody2D>().transform.position.y >(GetComponent<Rigidbody2D>().transform.position.y +dist))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (follow.GetComponent<Rigidbody2D>().transform.position.y < (GetComponent<Rigidbody2D>().transform.position.y - dist))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (follow.GetComponent<Rigidbody2D>().transform.position.x > (GetComponent<Rigidbody2D>().transform.position.x + dist))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (follow.GetComponent<Rigidbody2D>().transform.position.x < (GetComponent<Rigidbody2D>().transform.position.x - dist))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
