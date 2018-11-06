using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool endgame = false;

    public void GameOver()
    {
        if (endgame == false)
        {
            endgame = true;

            Debug.Log("Game Over");
            SceneManager.LoadScene(2);

        }
        
    }


}

