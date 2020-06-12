using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    public Text HighscoreText;
    
    void Start()
    {
        HighscoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }

    
}
