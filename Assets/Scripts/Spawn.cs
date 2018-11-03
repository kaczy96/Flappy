using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject obsctacle;
    public float InstantiationTimer;
    public float InstanttiationTimerStart;
    

    void Start ()
    {
    }
	
	void Update ()
    {
        Create();
    }


    void Create()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            int randomY = Random.Range(-2, 3);
            Instantiate(obsctacle, new Vector2(Random.value, Random.value * randomY), Quaternion.identity);
            InstantiationTimer = InstanttiationTimerStart;
        }

    }
}
