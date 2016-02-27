using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public Transform player;


	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        var x =  player.position.x;
        var y = player.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
	}
}
