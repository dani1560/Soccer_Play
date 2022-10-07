using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using UnityEngine.SocialPlatforms.Impl;

public class AnimationGuide : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject txt;
    GameObject txt2;
    GameObject Img;
    GameObject Soccerball;
    GameObject spike;
    GameObject Score;
    int click_counts;

    void Start()
    {
        txt2 = gameObject.transform.GetChild(3).gameObject;
        txt = gameObject.transform.GetChild(1).gameObject;
        Img = gameObject.transform.GetChild(0).gameObject;
        InvokeRepeating("GuideScreen", 0.5f, 1.5f);
        spike = GameObject.Find("Spikes");
        Score = GameObject.Find("Score");
        Soccerball = GameObject.Find("Soccer Ball");
        txt2.SetActive(false);
       // PlayerPrefs.SetString("tutorial_status", "");
    }

    // Update is called once per frame
    void GuideScreen()
    {
        StartCoroutine(animationPlay());
    }

    IEnumerator animationPlay()
    {
        LeanTween.scale(txt, new Vector3(1.2f, 1.2f, 1f), 1f);
        LeanTween.scale(Img, new Vector3(1.2f, 1.2f, 1f), 1f);
        yield return new WaitForSeconds(1f);
        LeanTween.scale(txt, new Vector3(1f, 1f, 1f), 1f);
        LeanTween.scale(Img, new Vector3(1f, 1f, 1f), 1f);
    }

    public void OnScreenClick()
    {
        if (click_counts == 0 && PlayerPrefs.GetString("tutorial_status") == "")
        {
            Soccerball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Soccerball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
            txt.SetActive(false);
            txt2.SetActive(true);
            click_counts = 1;

            Debug.Log("1 chala");
        }
    }
    public void OnHandClick()
    {
        if (click_counts == 1)
        {
            LeanTween.move(Soccerball, new Vector3(4.37f, 19.8f, -13.47f), 1f);
            Soccerball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            LeanTween.moveLocalY(spike, -156.4f, 1f);
            click_counts = 2;
            Debug.Log("2 chala");

        }
        else if (click_counts == 2 || PlayerPrefs.GetString("tutorial_status") == "0")
        {
            if (PlayerPrefs.GetString("tutorial_status") == "0")
            {
                LeanTween.moveLocalY(spike, -156.4f, 1f);
            }
            Score.GetComponent<ScoreCounter>().enabled = true;
            gameObject.SetActive(false);
            Soccerball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Soccerball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
            click_counts = 3;
            PlayerPrefs.SetString("tutorial_status", "0");
            Debug.Log("3 chala");
        }

    }


}
