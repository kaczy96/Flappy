using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle"  || collision.gameObject.tag == "Ground")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
