using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

    public float moveSpeed;
	// Use this for initialization
	void Start () {
        Move();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
