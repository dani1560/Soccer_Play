using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreCounter : MonoBehaviour
{
    TextMeshPro scoreCard;
    public int score;

    void Start()
    {
        score = 0;
        scoreCard = gameObject.GetComponent<TextMeshPro>();
        InvokeRepeating("ScoreFunction", 1f, 1f);
    }

    void ScoreFunction()
    {
        score++;
        scoreCard.SetText(score.ToString());
        
    }

}
