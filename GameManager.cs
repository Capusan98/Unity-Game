using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
  
    public float restartDelay = 1f;
    bool GameHasEnded = false;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {   
            GameHasEnded = true;
            
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
       
    }
}
