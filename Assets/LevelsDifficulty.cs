using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelsDifficulty : MonoBehaviour
{
    int LevelUp;
    int levelStatus = 0;
    GameObject levels;

    private void Start()
    {
        levels = GameObject.Find("Level");
    }

    void Update()
    {
        LevelUp = GameObject.Find("Score").GetComponent<ScoreCounter>().score;

        if (LevelUp > 20 && levelStatus == 0)
        {
            gameObject.GetComponent<Rigidbody>().mass = 0.5f;
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 2"));
            levelStatus = 1;
        }
    }
    IEnumerator fontAnimation(string txt)
    {
        LeanTween.scaleY(levels, 10f, 1f);
        yield return new WaitForSeconds(2);
        
        levels.GetComponent<TextMeshPro>().SetText(txt);
        LeanTween.scaleY(levels, 1f, 1f);

        //level up audio
        levels.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1);
    }
}
