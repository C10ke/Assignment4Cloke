using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highScores;
    public int PinCount;
    //pincount
    
    public PlayerData (Score score)
    {
        PinCount = Score.PinCount;
    }
}
