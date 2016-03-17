using UnityEngine;
using System.Collections;

public class BatMob : Entities{

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (strength <= 0 || speed <= 0 || knowledge <= 0 || sanity <= 0)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKey(KeyCode.I))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.J))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.K))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Rigidbody2D>().transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
