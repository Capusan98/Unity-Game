using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Text HighscoreText;
    private float NewScore;
    
     public float CoinBonus;
   
    private float AuxScore;
    // Start is called before the first frame update
    void Start()
    {

        
        NewScore = Time.time;
        HighscoreText.text = PlayerPrefs.GetFloat("HighScore",0).ToString("0");
    }
    public void CoinScore()
    {
       
        CoinBonus = CoinBonus + 10;
       

    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(CoinBonus);
       
        
        //Debug.Log(AuxScore);
        AuxScore = Time.time - NewScore + CoinBonus;
        ScoreText.text = AuxScore.ToString("0");
        if(AuxScore > PlayerPrefs.GetFloat("HighScore"))
            PlayerPrefs.SetFloat("HighScore", AuxScore);
        
    }
    public void ResetHighscore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        HighscoreText.text = "0";
    }
}
