using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelsDifficulty : MonoBehaviour
{
    //Script by Syed Daniyal Shahid

    int LevelUp;
    int levelStatus = 0;
    GameObject levels;
    GameObject spikes1;
    GameObject spikes2;
    GameObject spikes3;
    GameObject spikes4;
    GameObject spike_ball;
    GameObject spike_ball2;

    private void Start()
    {
        levels = GameObject.Find("Level");
        spikes1 = GameObject.Find("Spikes");
        spikes2 = GameObject.Find("Spikes2");
        spikes3 = GameObject.Find("Spikes3");
        spikes4 = GameObject.Find("Spikes4");
        spike_ball = GameObject.Find("spikeballs_all").transform.GetChild(0).gameObject;
        spike_ball2 = GameObject.Find("spikeballs_all").transform.GetChild(1).gameObject;
    }

    void Update()
    {
        LevelUp = GameObject.Find("Score").GetComponent<ScoreCounter>().score;

        #region --- Levels --- Code here --------

        //Level 2
        if (LevelUp == 100 && levelStatus == 0)
        {  
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 2", 1.4f));
            levelStatus = 1;
            spike_ball.SetActive(true);
        }

        //LEVEL 3
        else if (LevelUp == 300 && levelStatus == 1)
        {
            Debug.Log("levels_up");
            //spikes 2 entered
            StartCoroutine(fontAnimation("LEVEL 3", 1.8f));
            InvokeRepeating("spikes2_play", 1f, 3f);
            levelStatus = 2;
            
        }

        //Level 4
        else if (LevelUp == 500 && levelStatus == 2)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 4", 1.8f));
            InvokeRepeating("spikes_play", 1f, 3f);
            levelStatus = 3;
            LeanTween.moveLocalY(spike_ball, 12f, 1f);
            
        }

       
        //Level 5
        else if (LevelUp == 700 && levelStatus == 3)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 5", 1.8f));
            CancelInvoke("spikes_play");
            LeanTween.moveLocalY(spikes1, -156.17f, 1f);

            CancelInvoke("spikes2_play");
            LeanTween.moveLocalY(spikes2, -157.03f, 1f);
            levelStatus = 4;

            spike_ball.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball.GetComponent<ballspikesAnimation>().startForce.x = -2f;
            spike_ball.GetComponent<ballspikesAnimation>().enabled = true;

        }

        else if (LevelUp == 800 && levelStatus == 4)
        {
            Debug.Log("levels_up");
            InvokeRepeating("spikes_play_final", 1f, 3f);
            levelStatus = 5;
        }
    
        //Level 6
        else if (LevelUp == 1000 && levelStatus == 5)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 6", 1.9f));
            InvokeRepeating("spikes2_play_final", 1f, 3f);
            levelStatus = 6;
        }

        //Level 7
        else if (LevelUp == 1300 && levelStatus == 6)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 7", 1.9f));
            levelStatus = 7;
        }

        //Level 8
        else if (LevelUp == 1500 && levelStatus == 7)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 8", 1.9f));
            levelStatus = 8;
            LeanTween.moveLocalY(spike_ball, 10f, 1f);
        }

        //Level 9
        else if (LevelUp == 1700 && levelStatus == 8)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 9", 1.9f));
            CancelInvoke("spikes_play_final");
            CancelInvoke("spikes2_play_final");
            LeanTween.moveLocalY(spikes1, -156.31f, 1f);
            LeanTween.moveLocalY(spikes2, -157.02f, 1f);
            levelStatus = 9;

            spike_ball.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball.GetComponent<ballspikesAnimation>().startForce.x = 1.5f;
            spike_ball.GetComponent<ballspikesAnimation>().enabled = true;

        }

        //Level 10
        else if (LevelUp == 1900 && levelStatus == 9)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 10", 1.9f));
            LeanTween.moveLocalY(spikes1, -152.43f, 1f);
            LeanTween.moveLocalY(spikes2, -160.25f, 1f);
            levelStatus = 10;

         
        }

        //Level 11
        else if (LevelUp == 2100 && levelStatus == 10)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 11", 1.9f));
            LeanTween.moveLocalY(spikes1, -152.43f, 1f);
            LeanTween.moveLocalY(spikes2, -160.25f, 1f);
            levelStatus = 11;
        }

        //Level 12
        else if (LevelUp == 2300 && levelStatus == 11)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 12", 1.9f));
            LeanTween.moveLocalY(spikes1, -151.62f, 1f);
            LeanTween.moveLocalY(spikes2, -157.08f, 1f);
            levelStatus = 12;
        }

        //Level 13
        else if (LevelUp == 2500 && levelStatus == 12)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 13", 1.9f));
            LeanTween.moveLocalY(spikes1, -156.2f, 1f);
            levelStatus = 13;
        }

        //Level 14
        else if (LevelUp == 2700 && levelStatus == 13)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 14", 2f));
            LeanTween.moveLocalY(spikes2, -161f, 1f);
            levelStatus = 14;

        }

        //Level 15
        else if (LevelUp == 2900 && levelStatus == 14)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 15", 2f));
            LeanTween.moveLocalY(spikes1, -159.6f, 1f);
            LeanTween.moveLocalY(spikes2, -153.67f, 1f);
            LeanTween.moveLocalX(spikes3, 169.08f, 1f);
            LeanTween.moveLocalX(spikes4, -160.61f, 1f);
            levelStatus = 15;

            LeanTween.moveLocalY(spike_ball, 15f, 1f);

        }

        //Level 16
        else if (LevelUp == 3100 && levelStatus == 15)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 16", 2f));
            LeanTween.moveLocalY(spikes1, -156.2f, 1f);
            levelStatus = 16;
           
            spike_ball.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball.GetComponent<ballspikesAnimation>().startForce.x = 1f;
            spike_ball.GetComponent<ballspikesAnimation>().enabled = true;
            LeanTween.moveLocalY(spike_ball, 4f, 1f);
        }

        //Level 17
        else if (LevelUp == 3300 && levelStatus == 16)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 17", 2f));
            LeanTween.moveLocalY(spikes2, -157.03f, 1f);
            levelStatus = 17;
          
        }

        //Level 18
        else if (LevelUp == 3500 && levelStatus == 17)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 18", 2f));
            LeanTween.moveLocalY(spikes1, -154.06f, 1f);
            levelStatus = 18;
        }

        //Level 19
        else if (LevelUp == 3700 && levelStatus == 18)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 19", 2f));
            LeanTween.moveLocalY(spikes2, -158.07f, 1f);
            levelStatus = 19;
        }

        //Level 20
        else if (LevelUp == 4000 && levelStatus == 19)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 20", 2.1f));
            LeanTween.moveLocalY(spikes1, -156.09f, 1f);
            levelStatus = 20;
        }

        //Level 21
        else if (LevelUp == 4300 && levelStatus == 20)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 21", 2.1f));
            LeanTween.moveLocalY(spikes2, -157.16f, 1f);
            levelStatus = 21;
        }

        //Level 22
        else if (LevelUp == 4600 && levelStatus == 21)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 22", 2f));
            LeanTween.moveLocalX(spikes3, 167.89f, 1f);
            LeanTween.moveLocalX(spikes4, -159.43f, 1f);
            levelStatus = 22;
        }

        //Level 23
        else if (LevelUp == 4900 && levelStatus == 22)
        {
            Debug.Log("levels_up");
            gameObject.GetComponent<Ball_Controller>().forceUp = 5;
            StartCoroutine(fontAnimation("LEVEL 23", 2f));
            levelStatus = 23;
        }

        //Level 24
        else if (LevelUp == 5200 && levelStatus == 23)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 24", 2f));
            LeanTween.moveLocalX(spikes3, 169.31f, 1f);
            LeanTween.moveLocalX(spikes4, -160.77f, 1f);
            levelStatus = 24;
        }

     
        else if (LevelUp == 5400 && levelStatus == 24)
        {
            spike_ball2.SetActive(true);
            levelStatus = 25;
        }

        //Level 25
        else if (LevelUp == 6000 && levelStatus == 25)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 25", 1.9f));
            spike_ball2.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball2.GetComponent<ballspikesAnimation>().startForce.x = 2f;
            spike_ball2.GetComponent<ballspikesAnimation>().enabled = true;
            levelStatus = 26;
        }

        //Level 26
        else if (LevelUp == 6500 && levelStatus == 26)
        {
            Debug.Log("levels_up");
            StartCoroutine(fontAnimation("LEVEL 26", 1.9f));
        
            LeanTween.moveLocalY(spike_ball, 6f, 1f);
            LeanTween.moveLocalY(spike_ball2, 6f, 1f);
            levelStatus = 27;
        }
        else if (LevelUp == 6700 && levelStatus == 27)
        {
            spike_ball2.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball2.GetComponent<ballspikesAnimation>().startForce.x = 1f;
            spike_ball2.GetComponent<ballspikesAnimation>().enabled = true;

            gameObject.GetComponent<Ball_Controller>().forceUp = 0;
            LeanTween.moveLocalY(spike_ball, 6f, 1f);
            LeanTween.moveLocalY(spike_ball2, 6f, 1f);

            spike_ball.GetComponent<ballspikesAnimation>().enabled = false;
            spike_ball.GetComponent<ballspikesAnimation>().startForce.x = -1f;
            spike_ball.GetComponent<ballspikesAnimation>().enabled = true;
            levelStatus = 28;
        }


        #endregion
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
