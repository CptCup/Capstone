using UnityEngine;
using System.Collections;

public class Player : Entities {
	// Use this for initialization
	void Start () {
	
	}

    public BoardManager triggers;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.isTrigger)
        {
            string caseS = coll.tag;
            switch (caseS)
            {
                case "Door":
                    if (coll.GetComponent<Door>().isOpen == true)
                    {
                        coll.GetComponent<Door>().isOpen = false;
                        triggers.spawnRoom(coll.GetComponent<Door>().posDoor, coll.GetComponent<Door>().exitIdentity);
                        //spawn a new room
                        Debug.Log(coll.GetComponent<Door>().isOpen);
                        Destroy(coll.GetComponent<Collider2D>());
                    }
                    Debug.Log("Colliding with a door works");
                    break;

                case "Mob":
                    coll.GetComponent<BatMob>().strength -= 1;
                    Debug.Log(coll.GetComponent<BatMob>().strength);
                    Debug.Log("Colliding with a mob works");
                    break;

                case "Player":
                    Debug.Log("Colliding with a player works");
                    break;
            }

        }
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
