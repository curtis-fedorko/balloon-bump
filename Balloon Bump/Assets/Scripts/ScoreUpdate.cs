using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text score; 

    // Update is called once per frame
    void Update()
    {
        float timey = BalloonMove.getScore(); 
        score.text = timey.ToString("0"); 
        
    }
}
