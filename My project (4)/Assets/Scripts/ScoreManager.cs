using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //private int score = 0;
    private TextMeshProUGUI scoreText;
    public static int scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + Mathf.Round(scoreCount);
    }
}
