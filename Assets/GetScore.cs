using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScore : MonoBehaviour
{

    public Text fscore;
    float score = 0;

    private void ShowScore()
    {
        Debug.Log(score);
        score = Score.points;
        fscore.text = score.ToString();
    }
    
}
