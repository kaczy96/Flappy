using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text score;
    public static float points = 0;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "AddPoint")
        {
            ++points;
            Debug.Log(points);
        }
        score.text = points.ToString();


    }
}
