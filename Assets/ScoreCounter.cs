using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreCounter : MonoBehaviour
{
    //Script by Syed Daniyal Shahid

    TextMeshPro scoreCard;
    public int score;
    GameObject foot_ball;
    public bool GameEndsStatus;

    void Start()
    {
        score = 0;
        foot_ball = GameObject.Find("Soccer Ball");
        scoreCard = gameObject.GetComponent<TextMeshPro>();
        InvokeRepeating("ScoreFunction", 0.05f, 0.05f);
    }

    void ScoreFunction()
    {
        if (!GameEndsStatus)
        {
            score++;
        }
        scoreCard.SetText(score.ToString());
        
    }

}
