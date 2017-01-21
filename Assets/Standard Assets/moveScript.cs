using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour {
    
    public Vector2 speed = new Vector2(50, 50);
    private Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;

    void Update()
    {
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = movement;
    }
}
