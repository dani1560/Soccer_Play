using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelsDifficulty : MonoBehaviour
{
    int LevelUp;
    int levelStatus = 0;
    GameObject levels;
    GameObject spikes1;
    GameObject spikes2;

    private void Start()
    {
        levels = GameObject.Find("Level");
        spikes1 = GameObject.Find("Spikes");
        spikes2 = GameObject.Find("Spikes2");
    }

    void Update()
    {
        LevelUp = GameObject.Find("Score").GetComponent<ScoreCounter>().score;

        //Level 1
        if (LevelUp == 200 && levelStatus == 0)
        {  
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 2", 0.5f));
            levelStatus = 1;
        }

        //Level 2
        else if (LevelUp == 500 && levelStatus == 1)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 3", 0.3f));
            levelStatus = 2;
        }

        //Level 3
        else if (LevelUp == 1000 && levelStatus == 2)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 4", 0.2f));
            levelStatus = 3;
        }

        //Level 4
        else if (LevelUp == 1500 && levelStatus == 3)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 4", 0.1f));
            levelStatus = 4;
        }

        //Level 5
        else if (LevelUp == 1800 && levelStatus == 4)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 5", 0.8f));
            levelStatus = 5;
        }

   
        else if (LevelUp == 2000 && levelStatus == 5)
        {
            Debug.Log("levels_up");
            //spikes 2 entered
            StartCoroutine(fontAnimation("LEVEL 5", 0.9f));
            LeanTween.moveLocalY(spikes2, -157f, 1f);
            levelStatus = 6;
        }

        //Level 6
        else if (LevelUp == 2500 && levelStatus == 6)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 6", 0.5f));
            levelStatus = 7;
        }


    }
    IEnumerator fontAnimation(string txt, float ballMass)
    {

        LeanTween.scaleY(levels, 10f, 1f);
        yield return new WaitForSeconds(1);

        //level up audio
        levels.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);

        gameObject.GetComponent<Rigidbody>().mass = ballMass;
        levels.GetComponent<TextMeshPro>().SetText(txt);
        LeanTween.scaleY(levels, 1f, 1f);

        yield return new WaitForSeconds(1);
    }
}
