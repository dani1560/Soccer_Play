using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatingObjects : MonoBehaviour
{
    public GameObject Logo;
    public GameObject Start_btn;
    public GameObject Circle;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LogoAnimate());
        InvokeRepeating("ballRotate", 1f, 2f);
    }
    private void Reset()
    {
        Logo = GameObject.Find("Logo");
        Start_btn = GameObject.Find("Start_btn");
        Circle = GameObject.Find("Tutorial_btn");
    }

    // Update is called once per frame

    void ballRotate()
    {
        StartCoroutine(animatingObj());
       
    }
    IEnumerator animatingObj()
    {
        LeanTween.scale(Circle, new Vector3(1.2f, 1.2f, 1.2f), 1f);
        LeanTween.moveLocalY(Start_btn, -280.1f, 1f);
        yield return new WaitForSeconds(1f);
        LeanTween.moveLocalY(Start_btn, -312.8185f, 1f);
        LeanTween.scale(Circle, Vector3.one, 1f);
    }

    IEnumerator LogoAnimate()
    {
        yield return new WaitForSeconds(0.5f);
        LeanTween.moveLocalX(Logo, -157f, 0.2f);
        yield return new WaitForSeconds(0.2f);
        LeanTween.moveLocalX(Logo, 0f, 0.2f);

    }

        public void OnClickbtn()
    {
        SceneManager.LoadScene(1);
    }

}
