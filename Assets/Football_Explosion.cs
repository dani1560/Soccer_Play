using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Football_Explosion : MonoBehaviour
{
    public GameObject football_particle;
    public GameObject football;
    public GameObject GameEndSound;
    public GameObject Score;
    // Start is called before the first frame update

    private void Reset()
    {
        football = GameObject.Find("Soccer Ball");
        Score = GameObject.Find("Score");

        football_particle = football.transform.GetChild(0).gameObject;
        GameEndSound = football.transform.GetChild(1).gameObject;
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == football.name)
        {
            GameEndSound.SetActive(true);
            Score.GetComponent<ScoreCounter>().GameEndsStatus = true;
            StartCoroutine(Explosion());
        }
    }

    IEnumerator Explosion()
    {
        football_particle.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        LeanTween.scale(football, new Vector3(0f, 0f, 0f), 0.5f);
        football.GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(4f);
        football.SetActive(false);
        
    }
}
