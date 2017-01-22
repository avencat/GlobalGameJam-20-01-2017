using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour {
    
    Vector3 direction = new Vector3(-0.4f, 0, 0);

    void Start()
    {
        gameObject.transform.position = new Vector3(40, Random.Range(-19, 19), 0);
    }

    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		transform.position = gameObject.transform.position + direction;
        if (screenPos.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
