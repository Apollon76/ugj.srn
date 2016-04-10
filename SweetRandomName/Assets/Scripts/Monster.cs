using UnityEngine;
using System.Collections;
using System;

public class Monster : DarkObject {
    public int damage;
    public GameObject player;
    private Rigidbody2D body;
    public Vector3 playerPosition;
    public float maxSpeed;

	void Start () {
        PreStart();
        body = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        ChangeWorld();
        float xSpeed = 0;
        if (isActive)
        {
            playerPosition = player.transform.position;
            int dir = Math.Sign(player.transform.position.x - transform.position.x);
            if (Vector3.Distance(player.transform.position, transform.position) < 1)
                xSpeed = dir * maxSpeed;
        }
        else
        {
            xSpeed = 0;
        }
        body.velocity = new Vector2(xSpeed, body.velocity.y);
	}
}
