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
            Instantiate(obsctacle, transform.position+=transform.forward*Time.deltaTime, Quaternion.identity);
            InstantiationTimer = InstanttiationTimerStart;
        }

    }
}
