using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocManager : MonoBehaviour {

    public Transform    bloc;
    public float        spawnDelay = 3f;
    public float        spawnTime = 2f;
    float timer = 0f;
    
	void Start () {
	}
	
	void Update () {
        if (spawnDelay <= Time.realtimeSinceStartup)
        {
            if (timer == 0f)
            {
                timer = Time.realtimeSinceStartup;
            }
            if (spawnTime >= 0.5f && timer + spawnTime <= Time.realtimeSinceStartup)
            {
                timer = Time.realtimeSinceStartup;
                Spawn();
                if (0.5f <= 2f - (Time.realtimeSinceStartup / 20))
                    spawnTime = 2f - (Time.realtimeSinceStartup / 20);
                else
                    spawnTime = 0.5f;
            }
        }
    }

    void Spawn() {
        Transform newGameObject = Instantiate(bloc);
    }
}
