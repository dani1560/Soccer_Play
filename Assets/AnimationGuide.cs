using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimationGuide : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject txt;
    GameObject Img;
    void Start()
    {
        txt = gameObject.transform.GetChild(1).gameObject;
        Img = gameObject.transform.GetChild(0).gameObject;
        InvokeRepeating("GuideScreen", 0.5f, 1.5f);
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
}
