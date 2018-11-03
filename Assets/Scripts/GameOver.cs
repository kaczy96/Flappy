using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
    }
}
