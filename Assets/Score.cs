using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int PinCount;

    public Text text;
    public Text hightScore;
    public Text gameOverScore;
    
    void Start()
    {
        PinCount = 0;
        hightScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameOverScore.text = PlayerPrefs.GetInt("GAMEOVERSCORE", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = PinCount.ToString();
        PlayerPrefs.SetInt("GAMEOVERSCORE", PinCount);



        if (PinCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", PinCount);
            hightScore.text = PinCount.ToString();
        }
        
        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        hightScore.text = "0";

    }

    public void SaveGame()
    {
        Save.SavePlayer(this);

    }

    public void LoadGame()
    {
        PlayerData data = Save.LoadPlayer();

        PinCount = data.PinCount;
    }
}
