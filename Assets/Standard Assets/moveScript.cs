using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour {
    
    public Vector2 speed = new Vector2(10, 10);
    private Vector2 direction = new Vector2(-1f, 0);
    private Vector2 movement;

    void Start()
    {
        gameObject.transform.position = new Vector3(40, Random.Range(-19, 19), 0);
    }

    void Update()
    {
        movement = new Vector2(
          speed.x * direction.x,
          0);

    }

    void FixedUpdate()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        GetComponent<Rigidbody>().velocity = movement;
        if (screenPos.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
