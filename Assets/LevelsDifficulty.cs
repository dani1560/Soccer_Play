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

        //Level 2
        if (LevelUp == 200 && levelStatus == 0)
        {  
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 2", 0.5f));
            levelStatus = 1;
        }

       //Level 3
        else if (LevelUp == 500 && levelStatus == 1)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 3", 0.3f));
            levelStatus = 2;
        }

        //Level 4
        else if (LevelUp == 700 && levelStatus == 2)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 4", 0.2f));
            levelStatus = 3;
        }

        //Level 5
        else if (LevelUp == 1000 && levelStatus == 3)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 5", 0.7f));
            levelStatus = 4;
        }

        else if (LevelUp == 1200 && levelStatus == 4)
        {
            Debug.Log("levels_up");
            //spikes 2 entered
            StartCoroutine(fontAnimation("LEVEL 5", 0.6f));
            InvokeRepeating("spikes2_play", 1f, 3f);
            levelStatus = 5;
        }

        //Level 6
        else if (LevelUp == 1500 && levelStatus == 5)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 6", 0.5f));
            InvokeRepeating("spikes_play", 1f, 3f);
            levelStatus = 6;
        }

        else if (LevelUp == 2000 && levelStatus == 6)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 6", 0.5f));
            levelStatus = 7;
        }

        //Level 7
        else if (LevelUp == 2200 && levelStatus == 7)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 7", 0.45f));
            CancelInvoke("spikes_play");
            CancelInvoke("spikes2_play");
            LeanTween.moveLocalY(spikes1, -156.17f, 1f);
            LeanTween.moveLocalY(spikes2, -157.03f, 1f);
            levelStatus = 8;
        }

        //Level 8
        else if (LevelUp == 2500 && levelStatus == 8)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 8", 0.4f));
            InvokeRepeating("spikes_play_final", 1f, 3f);
            levelStatus = 9;
        }
    
        //Level 9
        else if (LevelUp == 3000 && levelStatus == 9)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 9", 0.4f));
            InvokeRepeating("spikes2_play_final", 1f, 3f);
            levelStatus = 10;
        }

        //Level 10
        else if (LevelUp == 3500 && levelStatus == 10)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 10", 0.35f));
            levelStatus = 11;
        }

        //Level 11
        else if (LevelUp == 4000 && levelStatus == 11)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 11", 0.35f));
            levelStatus = 12;
        }
        //Level 12
        else if (LevelUp == 4500 && levelStatus == 12)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 12", 0.3f));
            CancelInvoke("spikes_play_final");
            CancelInvoke("spikes2_play_final");
            LeanTween.moveLocalY(spikes1, -156.31f, 1f);
            LeanTween.moveLocalY(spikes2, -157.02f, 1f);
            levelStatus = 13;
        }

        //Level 13
        else if (LevelUp == 5000 && levelStatus == 13)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 13", 0.3f));
            LeanTween.moveLocalY(spikes1, -152.43f, 1f);
            LeanTween.moveLocalY(spikes2, -160.25f, 1f);
            levelStatus = 14;
        }

        //Level 14
        else if (LevelUp == 5500 && levelStatus == 14)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 14", 0.2f));
            LeanTween.moveLocalY(spikes1, -152.43f, 1f);
            LeanTween.moveLocalY(spikes2, -160.25f, 1f);
            levelStatus = 15;
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

    IEnumerator spikes_animation(GameObject obj, float start_position, float end_position)
    {
        LeanTween.moveLocalY(obj, start_position, 1f);
        yield return new WaitForSeconds(1f);
        LeanTween.moveLocalY(obj, end_position, 1f);
        yield return new WaitForSeconds(2f);
    }

    void spikes2_play() {

        StartCoroutine(spikes_animation(spikes2, -157.03f, -153.67f));
    }

    void spikes_play()
    {

        StartCoroutine(spikes_animation(spikes1, -159.6f, -156.17f));
    }

    void spikes_play_final()
    {
        StartCoroutine(spikes_animation(spikes1, -151.77f, -156.17f));
    }

    void spikes2_play_final()
    {

        StartCoroutine(spikes_animation(spikes2, -159.75f, -157.01f));
    }
}
