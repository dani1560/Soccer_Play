using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GmeOverScript : MonoBehaviour
{
    //Script by Syed Daniyal Shahid

    GameObject circle;
    GameObject Score;

    void Start()
    {
        circle = GameObject.Find("Circle");
        InvokeRepeating("ballRotate", 1f, 2f);
        Score = GameObject.Find("Score");
        Score.GetComponent<TextMeshProUGUI>().SetText(PlayerPrefs.GetString("scoreFinal"));
    }

    void ballRotate()
    {
        StartCoroutine(animatingObj());
    }
    
    IEnumerator animatingObj()
    {
        LeanTween.scale(circle, new Vector3(1.2f, 1.2f, 1.2f), 1f);
        yield return new WaitForSeconds(1f);
        LeanTween.scale(circle, new Vector3(1f, 1f, 1f), 1f);
    }
    
    public void restartClick()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitAppClick()
    {
        Application.Quit();
    }
}
