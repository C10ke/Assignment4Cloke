using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 10.0f;
    public float timeRemaining;

    public Dropdown TimerDropDown;

    public void SetTime()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {


        //timelimit = PlayerPrefs.GetFloat("TimeLimit", 0);


        timeRemaining = timelimit;

        timeLimitText.text = "Time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        /*
        switch (TimerDropDown.value)
        {
            case 0:
                timelimit = 10.0f;
                PlayerPrefs.SetFloat("TimeLimit", timelimit);
                break;
            case 1:
                timelimit = 20.0f;
                PlayerPrefs.SetFloat("TimeLimit", timelimit);
                break;
            case 2:
                timelimit = 30.0f;
                PlayerPrefs.SetFloat("TimeLimit", timelimit);
                break;

        }
        */



        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "Game Over"; 
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("Credits");
        }

    }
}

